using Oracle.ManagedDataAccess.Client;
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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            //Начальные значения для ввода
            surnameBox.Text = "Фамилия";
            surnameBox.ForeColor = Color.Gray;

            nameBox.Text = "Имя";
            nameBox.ForeColor = Color.Gray;

            midNameBox.Text = "Отчество";
            midNameBox.ForeColor = Color.Gray;

            phoneBox.Text = "Телефон";
            phoneBox.ForeColor = Color.Gray;

            logBox.Text = "Логин";
            logBox.ForeColor = Color.Gray;

            passBox.Text = "Пароль";
            passBox.ForeColor = Color.Gray;

            passRepeatBox.Text = "Пароль";
            passRepeatBox.ForeColor = Color.Gray;

            subdivisionNumberBox.Text = "Номер подразделения";
            subdivisionNumberBox.ForeColor = Color.Gray;

        }



        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            UsersForm UsersForm = new UsersForm();
            UsersForm.Show();
        }

        //Начальые данные реализзация после ввода

        private void SurnameBox_Enter(object sender, EventArgs e)
        {
            if (surnameBox.Text == "Фамилия")
            {
                surnameBox.Text = "";
                surnameBox.ForeColor = Color.Black;
            }
        }

        private void SurnameBox_Leave(object sender, EventArgs e)
        {
            if (surnameBox.Text == "")
            {
                surnameBox.Text = "Фамилия";
                surnameBox.ForeColor = Color.Gray;
            }
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Имя")
            {
                nameBox.Text = "";
                nameBox.ForeColor = Color.Black;
            }
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Имя";
                nameBox.ForeColor = Color.Gray;
            }
        }

        private void MidNmeBox_Enter(object sender, EventArgs e)
        {
            if (midNameBox.Text == "Отчество")
            {
                midNameBox.Text = "";
                midNameBox.ForeColor = Color.Black;
            }
        }

        private void MidNameBox_Leave(object sender, EventArgs e)
        {
            if (midNameBox.Text == "")
            {
                midNameBox.Text = "Отчество";
                midNameBox.ForeColor = Color.Gray;
            }
        }

        private void PhoneBox_Enter(object sender, EventArgs e)
        {
            if (phoneBox.Text == "Телефон")
            {
                phoneBox.Text = "";
                phoneBox.ForeColor = Color.Black;
            }
        }

        private void PhoneBox_Leave(object sender, EventArgs e)
        {
            if (phoneBox.Text == "")
            {
                phoneBox.Text = "Телефон";
                phoneBox.ForeColor = Color.Gray;
            }
        }

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

        private void PassBox_Enter(object sender, EventArgs e)
        {
            if (passBox.Text == "Пароль")
            {
                passBox.Text = "";
                passBox.ForeColor = Color.Black;
            }
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (passBox.Text == "")
            {
                passBox.Text = "Пароль";
                passBox.ForeColor = Color.Gray;
            }
        }

        private void PassRepeatBox_Enter(object sender, EventArgs e)
        {
            if (passRepeatBox.Text == "Пароль")
            {
                passRepeatBox.Text = "";
                passRepeatBox.ForeColor = Color.Black;
            }
        }

        private void PassRepeatBox_Leave(object sender, EventArgs e)
        {
            if (passRepeatBox.Text == "")
            {
                passRepeatBox.Text = "Пароль";
                passRepeatBox.ForeColor = Color.Gray;
            }
        }

        private void SubdivisionNumberBox_Enter(object sender, EventArgs e)
        {
            if (subdivisionNumberBox.Text == "Номер подразделения")
            {
                subdivisionNumberBox.Text = "";
                subdivisionNumberBox.ForeColor = Color.Black;
            }
        }

        private void SubdivisionNumberBox_Leave(object sender, EventArgs e)
        {
            if (subdivisionNumberBox.Text == "")
            {
                subdivisionNumberBox.Text = "Номер подразделения";
                subdivisionNumberBox.ForeColor = Color.Gray;
            }
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            
                if (surnameBox.Text == "Фамилия")
                {
                    MessageBox.Show("Введите фамилию");
                    return;
                }

                if (nameBox.Text == "Имя")
                {
                    MessageBox.Show("Введите имя");
                    return;
                }

                if (midNameBox.Text == "Отчество")
                {
                    MessageBox.Show("Введите отчество");
                    return;
                }

                if (phoneBox.Text == "Телефон")
                {
                    MessageBox.Show("Введите номер телефона");
                    return;
                }

                if (logBox.Text == "Логин")
                {
                    MessageBox.Show("Введите логин");
                    return;
                }

                if (passBox.Text == "Пароль")
                {
                    MessageBox.Show("Введите пароль");
                    return;
                }

                if (passRepeatBox.Text == "Пароль")
                {
                    MessageBox.Show("Введите пароль");
                    return;
                }

                if (passRepeatBox.Text != passBox.Text)
                {
                    MessageBox.Show("Пароли не совпадают");
                    return;
                }

                if (subdivisionNumberBox.Text == "Номер подразделения")
                {
                    MessageBox.Show("Введите номер подразделения");
                    return;
                }

                if (IsDataExists())
                    return;

                string surename = surnameBox.Text;
                string name = nameBox.Text;
                string midname = midNameBox.Text;
                string phone = phoneBox.Text;
                string login = logBox.Text;
                string pass = passBox.Text;
                string num = subdivisionNumberBox.Text;

                string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

                OracleConnection connection = new OracleConnection(con);
                connection.Open();
                string sqls = "SELECT ID FROM SUBDIVISION WHERE NUM= '" + num + "'";
            OracleCommand command = new OracleCommand(sqls, connection);
            command.CommandType = CommandType.Text;
            OracleDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[1]);
                data[0][0] = reader[0].ToString();
            }
            string sub_id = data[0][0];
            reader.Close();

             
            string sql = "INSERT INTO USERS (ID, SURENAME, NAME, MIDNAME, SUBDIVISION_ID) VALUES (users_seq.nextval, '" + surename + "', '" + name + "', '" + midname + "', '" + sub_id + "')";

                command = new OracleCommand(sql, connection);
                command.CommandType = CommandType.Text;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавление успешно");
            }
            else
            {
                MessageBox.Show("Произошла ошибка добавления");
            }


            string sqlus = "SELECT MAX(ID) FROM USERS";
            OracleCommand command_max = new OracleCommand(sqlus, connection);
            command_max.CommandType = CommandType.Text;
            OracleDataReader reader_max = command_max.ExecuteReader();
            List<string[]> data_us = new List<string[]>();
            while (reader_max.Read())
            {
                data_us.Add(new string[1]);
                data_us[0][0] = reader_max[0].ToString();
            }
            string us_id = data_us[0][0];

            
            string sqli = "INSERT INTO AUTHORIZATION (LOGIN, PASSWORD, USERS_ID) VALUES ('" + login + "', '" + pass + "', '" + us_id + "')";
           
            OracleCommand command_log = new OracleCommand(sqli, connection);
            command_log.CommandType = CommandType.Text;
            if (command_log.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Произошла ошибка login добавления");
            }
            
            string sqlp = "INSERT INTO PHONE (USERS_ID, PHONE) VALUES ('" + us_id + "', '" + phone + "')";
            OracleCommand command_ph = new OracleCommand(sqlp, connection);
            command_ph.CommandType = CommandType.Text;
            if (command_ph.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Произошла ошибка phone добавления");
            }
            
            connection.Close();
        }

        //проверка на наличие схожих данных 
        public Boolean IsDataExists()
            {
                string login = logBox.Text;
                string phone = phoneBox.Text;
                string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

                OracleConnection connection = new OracleConnection(con);
                connection.Open();

                string sqls = "SELECT * FROM AUTHORIZATION WHERE LOGIN='" + login + "'";
                OracleCommand command = new OracleCommand(sqls, connection);
                command.CommandType = CommandType.Text;
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();
            if (table.Rows.Count > 1)
            {
                MessageBox.Show("Логин существует");
                return true;
            }
            else
            {

                string sqlp = "SELECT * FROM PHONE WHERE PHONE= '" + phone + "'";
                OracleCommand command_p = new OracleCommand(sqlp, connection);
                command.CommandType = CommandType.Text;
                OracleDataAdapter adapter_p = new OracleDataAdapter(command_p);
                DataTable table_p = new DataTable();
                adapter.Fill(table_p);
                connection.Close();
                if (table_p.Rows.Count > 1)
                {
                    MessageBox.Show("Телефон существует");
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
