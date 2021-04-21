using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ControlFlashDrives
{
    public partial class DelUsersForm : Form
    {
        public DelUsersForm()
        {
            InitializeComponent();

            logBox.Text = "Логин";
            logBox.ForeColor = Color.Gray;
        }

        //Начальые данные реализзация после ввода

        
        private void LogBox_Enter(object sender, EventArgs e)
        {
            if (logBox.Text == "Логин")
            {
                logBox.Text = "";
                logBox.ForeColor = Color.Black;
            }
        }

        private void LogBox_Leave(object sender, EventArgs e)
        {
            if (logBox.Text == "")
            {
                logBox.Text = "Логин";
                logBox.ForeColor = Color.Gray;
            }
        }

        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            UsersForm UsersForm = new UsersForm();
            UsersForm.Show();
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

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (logBox.Text == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (IsDataExists())
                return;

            string login = logBox.Text;


            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();
            string sqls = "SELECT USERS_ID FROM AUTHORIZATION WHERE LOGIN= '" + login + "'";
            OracleCommand command = new OracleCommand(sqls, connection);
            command.CommandType = CommandType.Text;
            OracleDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[1]);
                data[0][0] = reader[0].ToString();
            }
            string us_id = data[0][0];
            reader.Close();

            
            string sql = "DELETE FROM AUTHORIZATION WHERE LOGIN='" + login + "'";

            command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            if (command.ExecuteNonQuery() != 1)
            MessageBox.Show("Произошла ошибка удаления");
            
            string sqlp = "DELETE FROM PHONE WHERE USERS_ID='" + us_id + "'";

            command = new OracleCommand(sqlp, connection);
            command.CommandType = CommandType.Text;

            if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("Произошла ошибка удаления");



            string sqlu = "DELETE FROM USERS WHERE ID='" + us_id + "'";

            command = new OracleCommand(sqlu, connection);
            command.CommandType = CommandType.Text;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Удаление успешно");
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
            string login = logBox.Text;


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
                MessageBox.Show("Логина не существует");
                return true;
            }
            else
            {
                string sql = "SELECT USERS_ID FROM AUTHORIZATION WHERE LOGIN= '" + login + "'";
                OracleCommand command_us = new OracleCommand(sql, connection);
                command_us.CommandType = CommandType.Text;
                OracleDataReader reader = command_us.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[1]);
                    data[0][0] = reader[0].ToString();
                }
                string us_id = data[0][0];
                reader.Close();

                string sqlu = "SELECT * FROM USERS WHERE ID= '" + us_id + "'";
                command = new OracleCommand(sqlu, connection);
                command.CommandType = CommandType.Text;
                adapter = new OracleDataAdapter(command);
                DataTable data_us = new DataTable();
                adapter.Fill(data_us);
                
                if (data_us.Rows.Count < 1)
                {
                    MessageBox.Show("Логина не существует");
                    return true;
                }
                else
                {
                    string sqlp = "SELECT * FROM USERS WHERE ID= '" + us_id + "'";
                    command = new OracleCommand(sqlp, connection);
                    command.CommandType = CommandType.Text;
                    adapter = new OracleDataAdapter(command);
                    DataTable data_p = new DataTable();
                    adapter.Fill(data_p);
                    connection.Close();
                    if (data_p.Rows.Count < 1)
                    {
                        MessageBox.Show("Телефоа не существует");
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
        }
    }
}
