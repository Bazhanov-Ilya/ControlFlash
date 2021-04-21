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
    public partial class DelSubdivisionForm : Form
    {
        public DelSubdivisionForm()
        {
            InitializeComponent();
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


        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            SubdivisionForm SubdivisionForm = new SubdivisionForm();
            SubdivisionForm.Show();
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

        private void DelFlashButton_Click(object sender, EventArgs e)
        {
            if (subdivisionNumberBox.Text == "Номер")
            {
                MessageBox.Show("Введите номер");
                return;
            }

            if (IsDataExists())
                return;
            string num = subdivisionNumberBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sqli = "SELECT ID FROM SUBDIVISION WHERE NUM = '" + num + "'";

            OracleCommand command = new OracleCommand(sqli, connection);
            OracleDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            command.CommandType = CommandType.Text;

            while (reader.Read())
            {
                data.Add(new string[1]);
                data[0][0] = reader[0].ToString();
            }
            string id = data[0][0];
            reader.Close();

            string sqls = "DELETE FROM TIMES WHERE SUBDIVISION_ID='" + id + "'";
            command = new OracleCommand(sqls, connection);
            command.CommandType = CommandType.Text;

            Thread.Sleep(1000);
            
            string sql = "DELETE FROM SUBDIVISION WHERE NUM='" + num + "'";

            command = new OracleCommand(sql, connection);
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
            string num = subdivisionNumberBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT * FROM SUBDIVISION WHERE NUM= '" + num + "'";

            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            if (table.Rows.Count <1)
            {
                MessageBox.Show("Введенные не данные существуют");
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
