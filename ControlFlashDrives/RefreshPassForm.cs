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
    public partial class RefreshPassForm : Form
    {
        public RefreshPassForm()
        {
            InitializeComponent();

            //Начальные значения для ввода
            logBox.Text = "Логин";
            logBox.ForeColor = Color.Gray;

            PassBox.Text = "Старый пароль";
            PassBox.ForeColor = Color.Gray;

            NewPassBox.Text = "Новый пароль";
            NewPassBox.ForeColor = Color.Gray;

            ReNewPassBox.Text = "Повторите пароль";
            ReNewPassBox.ForeColor = Color.Gray;
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

        private void OldPassBox_Enter(object sender, EventArgs e)
        {
            if (PassBox.Text == "Старый пароль")
            {
                PassBox.Text = "";
                PassBox.ForeColor = Color.Black;
            }
        }


        private void OldPassBox_Leave(object sender, EventArgs e)
        {
            if (PassBox.Text == "")
            {
                PassBox.Text = "Старый пароль";
                PassBox.ForeColor = Color.Gray;
            }
        }

        private void NewPassBox_Enter(object sender, EventArgs e)
        {
            if (NewPassBox.Text == "Новый пароль")
            {
                NewPassBox.Text = "";
                NewPassBox.ForeColor = Color.Black;
            }
        }

        private void NewPassBox_Leave(object sender, EventArgs e)
        {
            if (NewPassBox.Text == "")
            {
                NewPassBox.Text = "Новый пароль";
                NewPassBox.ForeColor = Color.Gray;
            }
        }

        private void ReNewPassBox_Enter(object sender, EventArgs e)
        {
            if (ReNewPassBox.Text == "Повторите пароль")
            {
                ReNewPassBox.Text = "";
                ReNewPassBox.ForeColor = Color.Black;
            }
        }

        private void ReNewPassBox_Leave(object sender, EventArgs e)
        {
            if (ReNewPassBox.Text == "")
            {
                ReNewPassBox.Text = "Повторите пароль";
                ReNewPassBox.ForeColor = Color.Gray;
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

        private void ChangePassButton_Click(object sender, EventArgs e)
        {

            if (logBox.Text == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (PassBox.Text == "Старый пароль")
            {
                MessageBox.Show("Введите старый пароль");
                return;
            }

            if (NewPassBox.Text == "Новый пароль")
            {
                MessageBox.Show("Введите новый пароль");
                return;
            }

            if (PassBox.Text == NewPassBox.Text)
            {
                MessageBox.Show("Новый пароль совпадает со старым");
                return;
            }

            if (ReNewPassBox.Text == "Повторите пароль")
            {
                MessageBox.Show("Повторите новый пароль");
                return;
            }

            if (ReNewPassBox.Text != NewPassBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (IsDataExists())
                return;

            string login = logBox.Text;
            string new_pass = NewPassBox.Text;

            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();
            string sql = "UPDATE AUTHORIZATION SET PASSWORD='" + new_pass + "' WHERE LOGIN= '" + login + "'";
            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пароль изменен");
            }
            else
            {
                MessageBox.Show("Произошла ошибка изменения пароля");
            }

            connection.Close();
        }

        //проверка на наличие схожих данных 
        public Boolean IsDataExists()
        {
            string login = logBox.Text;
            string pass = PassBox.Text;
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
                string sql = "SELECT PASSWORD FROM AUTHORIZATION WHERE LOGIN= '" + login + "'";
                OracleCommand command_p = new OracleCommand(sql, connection);
                command_p.CommandType = CommandType.Text;
                OracleDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[1]);
                    data[0][0] = reader[0].ToString();
                }
                string password = data[0][0];
                connection.Close();
                if (password != pass)
                {
                    MessageBox.Show("Старый пароль неверный");
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
