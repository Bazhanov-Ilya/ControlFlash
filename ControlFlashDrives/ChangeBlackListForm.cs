using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlFlashDrives
{
    public partial class ChangeBlackListForm : Form
    {
        public ChangeBlackListForm()
        {
            InitializeComponent();

            LogBox.Text = "Логин";
            LogBox.ForeColor = Color.Gray;
        }

        private void LogBox_Enter(object sender, EventArgs e)
        {
            if (LogBox.Text == "Логин")
            {
                LogBox.Text = "";
                LogBox.ForeColor = Color.Black;
            }
        }

        private void LogBox_Leave(object sender, EventArgs e)
        {
            if (LogBox.Text == "")
            {
                LogBox.Text = "Логин";
                LogBox.ForeColor = Color.Gray;
            }
        }

        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            BlackListForm BlackListForm = new BlackListForm();
            BlackListForm.Show();
        }

        //Передвижение окна

        Point lastPoint;

        private void TopWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {


            if (LogBox.Text == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

           
            if (IsDataExists())
                return;

            string login = LogBox.Text;

            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT USERS_ID FROM AUTHORIZATION WHERE LOGIN= '" + login + "'";
            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;
            OracleDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[1]);
                data[0][0] = reader[0].ToString();
            }
            string us_id = data[0][0];

            string sql_bl = "DELETE FROM BLACK_LIST WHERE USERS_ID= '" + us_id + "'";
            OracleCommand command_bl = new OracleCommand(sql_bl, connection);
            command.CommandType = CommandType.Text;

            if (command_bl.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь удален из списка должников");
            }
            else
            {
                MessageBox.Show("Произошла ошибка удаления");
            }

            connection.Close();
        }

        //проверка на наличие схожих данных 
        public Boolean IsDataExists()
        {
            string login = LogBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sqls = "SELECT * FROM AUTHORIZATION WHERE LOGIN= '" + login + "'";
            OracleCommand command = new OracleCommand(sqls, connection);
            command.CommandType = CommandType.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Логин не существует");
                connection.Close();
                return true;
            }
            else
            {
                string sql = "SELECT USERS_ID FROM AUTHORIZATION WHERE LOGIN= '" + login + "'";
                OracleCommand command_p = new OracleCommand(sql, connection);
                command_p.CommandType = CommandType.Text;
                OracleDataReader reader = command_p.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[1]);
                    data[0][0] = reader[0].ToString();
                }
                string us_id = data[0][0];

                string sql_bl = "SELECT * FROM BLACK_LIST WHERE USERS_ID= '" + us_id + "'";
                OracleCommand command_bl = new OracleCommand(sql_bl, connection);
                command.CommandType = CommandType.Text;
                adapter = new OracleDataAdapter(command_bl);
                DataTable table_bl = new DataTable();
                adapter.Fill(table_bl);
                connection.Close();
                if (table_bl.Rows.Count < 1)
                {
                    MessageBox.Show("Данный пользователь не находится в списке должников");
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
