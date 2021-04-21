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
    public partial class IssueForm : Form
    {
        public IssueForm()
        {
            InitializeComponent();

            //Начальные значения для ввода
            logBox.Text = "Логин";
            logBox.ForeColor = Color.Gray;

            idFlashBox.Text = "id флеш-накопителя";
            idFlashBox.ForeColor = Color.Gray;
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

        private void IdFlashBox_Enter(object sender, EventArgs e)
        {
            if (idFlashBox.Text == "id флеш-накопителя")
            {
                idFlashBox.Text = "";
                idFlashBox.ForeColor = Color.Black;
            }
        }

        private void IdFlashBox_Leave(object sender, EventArgs e)
        {
            if (idFlashBox.Text == "")
            {
                idFlashBox.Text = "id флеш-накопителя";
                idFlashBox.ForeColor = Color.Gray;
            }
        }

        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
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

        private void IssueButton_Click(object sender, EventArgs e)
        {

            if (logBox.Text == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (idFlashBox.Text == "id флеш-накопителя")
            {
                MessageBox.Show("Введите номер флеш-накопителя");
                return;
            }

            if (IsDataExists())
                return;

            
            DateTime time = DateTime.Now;
            string login = logBox.Text;
            string flash = idFlashBox.Text;

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


            string sqlf = "SELECT ID FROM FLASH WHERE NUM= '" + flash + "'";
            OracleCommand commandf = new OracleCommand(sqlf, connection);
            commandf.CommandType = CommandType.Text;
            OracleDataReader readerf = commandf.ExecuteReader();
            List<string[]> dataf = new List<string[]>();
            while (readerf.Read())
            {
                dataf.Add(new string[1]);
                dataf[0][0] = readerf[0].ToString();
            }
            string f_id = dataf[0][0];

            string sqls = "SELECT SUBDIVISION_ID FROM USERS WHERE ID= '" + us_id + "'";
            OracleCommand command_s = new OracleCommand(sqls, connection);
            command_s.CommandType = CommandType.Text;
            OracleDataReader reader_s = command_s.ExecuteReader();
            List<string[]> data_s = new List<string[]>();
            while (reader_s.Read())
            {
                data_s.Add(new string[1]);
                data_s[0][0] = reader_s[0].ToString();
            }
            string sub_id = data_s[0][0];

            string sqlt = "SELECT TIMES FROM TIMES WHERE SUBDIVISION_ID= '" + sub_id + "'";
            OracleCommand command_t = new OracleCommand(sqlt, connection);
            command_t.CommandType = CommandType.Text;
            OracleDataReader reader_t = command_t.ExecuteReader();
            List<string[]> data_t = new List<string[]>();
            while (reader_t.Read())
            {
                data_t.Add(new string[1]);
                data_t[0][0] = reader_t[0].ToString();
            }
            string time_issue = data_t[0][0];

            int hours = int.Parse(time_issue.Split(':')[0]);
            int minuts = int.Parse(time_issue.Split(':').Last());
            string time_take = (time.AddHours(hours).AddMinutes(minuts)).ToString();
            string times_issue = time.ToString();

            string sqli = "INSERT INTO ISSUE (USERS_ID, FLASH_ID, TIME_ISSUE, TIME_TAKE) VALUES ('" + us_id + "', '" + f_id + "', '" + times_issue + "', '" + time_take + "')";
            OracleCommand command_i = new OracleCommand(sqli, connection);
            command_i.CommandType = CommandType.Text;
            if (command_i.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Произошла ошибка добавления");
            }
            else { 
            string sql_up = "UPDATE FLASH SET USED='" + login + "' WHERE NUM= '" + flash + "'";
            OracleCommand command_up = new OracleCommand(sql_up, connection);
            command_up.CommandType = CommandType.Text;
             if (command_up.ExecuteNonQuery() == 1)
             {
                 MessageBox.Show("Выдача успеша, необходимо сдать до "+time_take);
             }
             else
             {
                 MessageBox.Show("Произошло ошибка выдачи");
             }
             }

            connection.Close();
        }

        //проверка на наличие схожих данных 
        public Boolean IsDataExists()
        {
            string login = logBox.Text;
            string flash = idFlashBox.Text;
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
                string sql = "SELECT * FROM FLASH WHERE NUM= '" + flash + "'";
                OracleCommand command_f = new OracleCommand(sql, connection);
                command_f.CommandType = CommandType.Text;
                OracleDataAdapter adapter_f = new OracleDataAdapter(command_f);
                DataTable table_f = new DataTable();
                adapter_f.Fill(table_f);

                if (table_f.Rows.Count < 1)
                {
                    MessageBox.Show("Флеш-накопитель не существует");
                    connection.Close();
                    return true;
                }
                else
                {
                    string sqlf = "SELECT * FROM FLASH WHERE NUM= '" + flash + "' AND USED='нет'";
                    OracleCommand command_u = new OracleCommand(sqlf, connection);
                    command_u.CommandType = CommandType.Text;
                    OracleDataAdapter adapter_u = new OracleDataAdapter(command_f);
                    DataTable table_u = new DataTable();
                    adapter_u.Fill(table_u);

                    if (table_u.Rows.Count < 1)
                    {
                        MessageBox.Show("Флеш-накопитель уже выдан, проверьте список флеш-накопителей");
                        connection.Close();
                        return true;
                    }
                    else
                    {
                         string sql_us = "SELECT USERS_ID FROM AUTHORIZATION WHERE LOGIN= '" + login + "'";
                         OracleCommand command_us = new OracleCommand(sql_us, connection);
                         command_us.CommandType = CommandType.Text;
                         OracleDataReader reader_us = command_us.ExecuteReader();
                         List<string[]> data_us = new List<string[]>();
                         while (reader_us.Read())
                         {
                             data_us.Add(new string[1]);
                             data_us[0][0] = reader_us[0].ToString();
                         }
                         string us_id = data_us[0][0];

                         string sql_c = "SELECT * FROM BLACK_LIST WHERE USERS_ID='" + us_id + "'";
                         OracleCommand command_c = new OracleCommand(sql_c, connection);
                         command_c.CommandType = CommandType.Text;
                         OracleDataAdapter adapter_c = new OracleDataAdapter(command_c);
                         DataTable table_c = new DataTable();
                         adapter_c.Fill(table_c);

                         if (table_c.Rows.Count > 0)
                         {
                             MessageBox.Show("Пользователь в списке должников");
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
    }
}
