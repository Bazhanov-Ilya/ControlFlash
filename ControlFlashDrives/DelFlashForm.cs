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
    public partial class DelFlashForm : Form
    {
        public DelFlashForm()
        {
            InitializeComponent();

            //Начальные значения окна ввода
            IdFlashBox.Text = "Серийный номер";
            IdFlashBox.ForeColor = Color.Gray;
        }


        private void IdFlashBox_Enter(object sender, EventArgs e)
        {
            if (IdFlashBox.Text == "Серийный номер")
            {
                IdFlashBox.Text = "";
                IdFlashBox.ForeColor = Color.Black;
            }
        }

        private void IdFlashBox_Leave(object sender, EventArgs e)
        {
            if (IdFlashBox.Text == "")
            {
                IdFlashBox.Text = "Серийный номер";
                IdFlashBox.ForeColor = Color.Gray;
            }
        }

        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            FlashForm FlashForm = new FlashForm();
            FlashForm.Show();
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
            if (IdFlashBox.Text == "Номер")
            {
                MessageBox.Show("Введите номер");
                return;
            }

            if (IsDataExists())
                return;
            string num = IdFlashBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "DELETE FROM FLASH WHERE NUM='" + num + "'";

            OracleCommand command = new OracleCommand(sql, connection);
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
            string num = IdFlashBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT * FROM FLASH WHERE NUM= '" + num + "'";

            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            if (table.Rows.Count < 1)
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
