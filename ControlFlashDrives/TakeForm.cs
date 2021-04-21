using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ControlFlashDrives
{
    public partial class TakeForm : Form
    {
        public TakeForm()
        {
            InitializeComponent();

            //Начальные значения для ввода
           
            logBox.Text = "Логин";
            logBox.ForeColor = Color.Gray;

            idFlashBox.Text = "id флеш-накопителя";
            idFlashBox.ForeColor = Color.Gray;
        }

        //Начальные данные реализзация после ввода
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

        private void TakeButton_Click(object sender, EventArgs e)
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


            string sqlf = "SELECT ID,FIRM,DATE_FLASH FROM FLASH WHERE NUM= '" + flash + "'";
            OracleCommand commandf = new OracleCommand(sqlf, connection);
            commandf.CommandType = CommandType.Text;
            OracleDataReader readerf = commandf.ExecuteReader();
            List<string[]> dataf = new List<string[]>();
            while (readerf.Read())
            {
                dataf.Add(new string[3]);
                dataf[0][0] = readerf[0].ToString();
                dataf[0][1] = readerf[1].ToString();
                dataf[0][2] = readerf[2].ToString();
            }
            string f_id = dataf[0][0];
            string firm = dataf[0][1];
            string date_flash = dataf[0][2];

            string sqls = "SELECT SUBDIVISION_ID, SURENAME, NAME, MIDNAME FROM USERS WHERE ID= '" + us_id + "'";
            OracleCommand command_s = new OracleCommand(sqls, connection);
            command_s.CommandType = CommandType.Text;
            OracleDataReader reader_s = command_s.ExecuteReader();
            List<string[]> data_s = new List<string[]>();
            while (reader_s.Read())
            {
                data_s.Add(new string[4]);
                data_s[0][0] = reader_s[0].ToString();
                data_s[0][1] = reader_s[1].ToString();
                data_s[0][2] = reader_s[2].ToString();
                data_s[0][3] = reader_s[3].ToString();
            }
            string sub_id = data_s[0][0];
            string surename = data_s[0][1];
            string name = data_s[0][2];
            string midname = data_s[0][3];

            string sql_sub = "SELECT NUM,NAME,FULL_NAME FROM SUBDIVISION WHERE ID= '" + sub_id + "'";
            OracleCommand command_sub = new OracleCommand(sql_sub, connection);
            command_sub.CommandType = CommandType.Text;
            OracleDataReader reader_sub = command_sub.ExecuteReader();
            List<string[]> data_sub = new List<string[]>();
            while (reader_sub.Read())
            {
                data_sub.Add(new string[3]);
                data_sub[0][0] = reader_sub[0].ToString();
                data_sub[0][1] = reader_sub[1].ToString();
                data_sub[0][2] = reader_sub[2].ToString();
            }
            string num = data_sub[0][0];
            string sub_name = data_sub[0][1];
            string sub_full_name = data_sub[0][2];

            string sqlt = "SELECT TIME_ISSUE,TIME_TAKE FROM ISSUE WHERE USERS_ID= '" + us_id + "'";
            OracleCommand command_t = new OracleCommand(sqlt, connection);
            command_t.CommandType = CommandType.Text;
            OracleDataReader reader_t = command_t.ExecuteReader();
            List<string[]> data_t = new List<string[]>();
            while (reader_t.Read())
            {
                data_t.Add(new string[2]);
                data_t[0][0] = reader_t[0].ToString();
                data_t[0][1] = reader_t[1].ToString();
            }
            string time_issue = data_t[0][0];
            string time_take = data_t[0][1];

           

            string sqli = "DELETE FROM ISSUE WHERE USERS_ID='" + us_id + "'";
            OracleCommand command_i = new OracleCommand(sqli, connection);
            command_i.CommandType = CommandType.Text;
            if (command_i.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Произошла ошибка приема");
            }
            else
            {
                string sql_up = "UPDATE FLASH SET USED='нет' WHERE NUM= '" + flash + "'";
                OracleCommand command_up = new OracleCommand(sql_up, connection);
                command_up.CommandType = CommandType.Text;
                if (command_up.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Подготовка к печати отчета");
                    Print(surename, name, midname, login, num, sub_full_name, sub_name, flash, firm, date_flash, time_issue, time_take);
                }
                else
                {
                    MessageBox.Show("Произошло ошибка приема");
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

                if (table.Rows.Count < 1)
                {
                    MessageBox.Show("Флеш-накопитель не существует");
                    connection.Close();
                    return true;
                }
                else
                {
                    string sqlf = "SELECT USED FROM FLASH WHERE NUM= '" + flash + "'";
                    OracleCommand command_u = new OracleCommand(sqlf, connection);
                    command_u.CommandType = CommandType.Text;
                    OracleDataReader reader = command_u.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[1]);
                        data[0][0] = reader[0].ToString();
                    }
                    string status = data[0][0];
                    connection.Close();
                    if (status != login)
                    {
                        MessageBox.Show("Флеш-накопитель не закреплен за этим пользователем");
                        connection.Close();
                        return true;
                    }
                    else
                    {
                      return false;
                    }
                }
            }
        }

        private readonly string TemplateFile = @"C:\Users\Home.net\source\repos\ControlFlashDrives\ControlFlashDrives\Reports\Report.docx";


        private void Print(string surename, string name, string midname, string login, string num, string sub_full_name, string sub_name, string flash, string firm, string date_flash, string time_issue, string time_take)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                string time_now = DateTime.Now.ToString();
                var wordDocument = wordApp.Documents.Open(TemplateFile);
                ReplaceWordSrub("{surename}", surename, wordDocument);
                ReplaceWordSrub("{name}", name, wordDocument);
                ReplaceWordSrub("{midname}", midname, wordDocument);
                ReplaceWordSrub("{login}", login, wordDocument);
                ReplaceWordSrub("{num}", num, wordDocument);
                ReplaceWordSrub("{sub_full_name}", sub_full_name, wordDocument);
                ReplaceWordSrub("{sub_name}", sub_name, wordDocument);
                ReplaceWordSrub("{flash}", flash, wordDocument);
                ReplaceWordSrub("{firm}", firm, wordDocument);
                ReplaceWordSrub("{date_flash}", date_flash, wordDocument);
                ReplaceWordSrub("{time_issue}", time_issue, wordDocument);
                ReplaceWordSrub("{time_take}", time_take, wordDocument);
                ReplaceWordSrub("{time_now}", time_now, wordDocument);

                wordDocument.SaveAs(@"C:\Users\Home.net\source\repos\ControlFlashDrives\ControlFlashDrives\Reports\Report1.docx");
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка печати, flash-накопитель принят");
            }
        }

        private void ReplaceWordSrub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
