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
    public partial class ChangeTimeForm : Form
    {
        public ChangeTimeForm()
        {
            InitializeComponent();

            subdivisionNumberBox.Text = "Номер";
            subdivisionNumberBox.ForeColor = Color.Gray;

            NewTimeBox.Text = "Новое время (2:30)";
            NewTimeBox.ForeColor = Color.Gray;
        }
    

    private void SubdivisionNumberBox_Enter(object sender, EventArgs e)
        {
            if (subdivisionNumberBox.Text == "Номер")
            {
                subdivisionNumberBox.Text = "";
                subdivisionNumberBox.ForeColor = Color.Black;
            }
        }

        private void SubdivisionNumberBox_Leave(object sender, EventArgs e)
        {
            if (subdivisionNumberBox.Text == "")
            {
                subdivisionNumberBox.Text = "Номер";
                subdivisionNumberBox.ForeColor = Color.Gray;
            }
        }

        private void NewTimeBox_Enter(object sender, EventArgs e)
        {
            if (NewTimeBox.Text == "Новое время (2:30)")
            {
                NewTimeBox.Text = "";
                NewTimeBox.ForeColor = Color.Black;
            }
        }

        private void NewTimeBox_Leave(object sender, EventArgs e)
        {
            if (NewTimeBox.Text == "")
            {
                NewTimeBox.Text = "Новое время (2:30)";
                NewTimeBox.ForeColor = Color.Gray;
            }
        }

        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            TimeIssueForm TimeIssueForm = new TimeIssueForm();
            TimeIssueForm.Show();
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

        private void ChangeButton_Click(object sender, EventArgs e)
        {

            if (subdivisionNumberBox.Text == "Номер")
            {
                MessageBox.Show("Введите номер");
                return;
            }

            if (NewTimeBox.Text == "Новое время(2:30)")
            {
                MessageBox.Show("Введите новое время");
                return;
            }


            if (IsDataExists())
                return;
            string num = subdivisionNumberBox.Text;
            string time = NewTimeBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT ID FROM SUBDIVISION WHERE NUM = '"+num+"'";

            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

             OracleDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[1]);
                data[0][0] = reader[0].ToString();
            }
            var id = data[0][0];
            reader.Close();

            string sqli = "UPDATE TIMES SET TIMES='"+time+"' WHERE SUBDIVISION_ID='" + id+"'";
            command = new OracleCommand(sqli, connection);
            command.CommandType = CommandType.Text;

            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменение успешно");
            }
            else
            {
                MessageBox.Show("Произошла ошибка изменения");
            }
            connection.Close();

        }

        //проверка на наличие схожих данных 
        public Boolean IsDataExists()
        {
            string num = subdivisionNumberBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT ID FROM SUBDIVISION WHERE NUM = '" + num + "'";

            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            OracleDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[1]);
                data[0][0] = reader[0].ToString();
            }
            string id = data[0][0];
            reader.Close();

            string sqli = "SELECT * FROM TIMES WHERE SUBDIVIVISION_ID = '" + id + "'";

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            command = new OracleCommand(sqli, connection);
            command.CommandType = CommandType.Text;

            
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Введенные данные не существуют");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
