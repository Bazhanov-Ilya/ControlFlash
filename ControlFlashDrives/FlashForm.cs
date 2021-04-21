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
    public partial class FlashForm : Form
    {
        public FlashForm()
        {
            InitializeComponent();

            LoadData();
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
        
        //Кнопка закрытия
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Кнопка перехода к добавлению флеш-накопителя
        private void AddFlashButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddFlashForm AddFlashForm = new AddFlashForm();
            AddFlashForm.Show();
        }

        //Кнопка перехода к удаления флеш-накопителя
        private void DelFlashButton_Click(object sender, EventArgs e)
        {
            Hide();
            DelFlashForm DelFlashForm = new DelFlashForm();
            DelFlashForm.Show();
        }

        private void LoadData()
        {
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT  NUM, FIRM, DATE_FLASH, USED FROM FLASH";
            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            OracleDataAdapter adapter = new OracleDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            data.Columns[0].ColumnName = "Номер";
            data.Columns[1].ColumnName = "Фирма";
            data.Columns[2].ColumnName = "Дата введения в эксплуатацию";
            data.Columns[3].ColumnName = "Используется";
            dataGridView1.DataSource = data;

            connection.Clone();

        }
    }
}
