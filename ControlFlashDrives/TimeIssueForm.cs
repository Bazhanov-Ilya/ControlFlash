using Oracle.ManagedDataAccess.Client;
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
    public partial class TimeIssueForm : Form
    {
        public TimeIssueForm()
        {
            InitializeComponent();

            LoadData();
        }

        private void ReTimeButton_Click(object sender, EventArgs e)
        {
            Hide();
            ChangeTimeForm ChangeTimeForm = new ChangeTimeForm();
            ChangeTimeForm.Show();
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

        
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tIMESTableAdapter.FillBy(this.controlFlash.TIMES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void LoadData()
        {
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT  CONTROLLER.SUBDIVISION.NUM, CONTROLLER.SUBDIVISION.FULL_NAME, CONTROLLER.TIMES.TIMES FROM CONTROLLER.TIMES INNER JOIN CONTROLLER.SUBDIVISION ON CONTROLLER.TIMES.SUBDIVISION_ID = CONTROLLER.SUBDIVISION.ID";
            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            OracleDataAdapter adapter = new OracleDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            data.Columns[0].ColumnName = "Номер подразделения";
            data.Columns[1].ColumnName = "Полное наименование";
            data.Columns[2].ColumnName = "Время выдачи";
            dataGridView1.DataSource = data;

            connection.Clone();

        }

    }
}
