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
    public partial class BlackListForm : Form
    {
        public BlackListForm()
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

        //Кнопка изменения черного списка
        private void ReListButton_Click(object sender, EventArgs e)
        {
            Hide();
            ChangeBlackListForm ChangeBlackListForm = new ChangeBlackListForm();
            ChangeBlackListForm.Show();
        }

        private void LoadData()
        {
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT CONTROLLER.USERS.SURENAME, CONTROLLER.USERS.NAME, CONTROLLER.USERS.MIDNAME, CONTROLLER.SUBDIVISION.NUM, CONTROLLER.AUTHORIZATION.LOGIN,  CONTROLLER.PHONE.PHONE FROM CONTROLLER.BLACK_LIST INNER JOIN CONTROLLER.USERS ON CONTROLLER.BLACK_LIST.USERS_ID = CONTROLLER.USERS.ID INNER JOIN CONTROLLER.SUBDIVISION ON CONTROLLER.USERS.SUBDIVISION_ID = CONTROLLER.SUBDIVISION.ID INNER JOIN CONTROLLER.PHONE ON CONTROLLER.USERS.ID = CONTROLLER.PHONE.USERS_ID INNER JOIN CONTROLLER.AUTHORIZATION ON CONTROLLER.USERS.ID = CONTROLLER.AUTHORIZATION.USERS_ID";
            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            OracleDataAdapter adapter = new OracleDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            data.Columns[0].ColumnName = "Фамилия";
            data.Columns[1].ColumnName = "Имя";
            data.Columns[2].ColumnName = "Отчество";
            data.Columns[3].ColumnName = "Номер подразделения";
            data.Columns[4].ColumnName = "Логин";
            data.Columns[5].ColumnName = "Номер телефона";
            dataGridView1.DataSource = data;

            connection.Clone();

        }

    }
}
