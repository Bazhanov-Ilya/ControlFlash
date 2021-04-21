using CrystalDecisions.CrystalReports.Engine;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFlashDrives
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();

        }

        //Кнопка закрытия
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButon_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(161, 184, 190);

        }

        private void CloseButon_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
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

        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        //Загрузка двнных по времени
        private void LoadButton_Click(object sender, EventArgs e)
        {
            string time_ot = DateOt.Text + " 00:00:00";
            string time_do = DateDo.Text + " 23:59:59";
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT * FROM TAKE WHERE TIME_ISSUE >= '"+time_ot+ "' AND TIME_ISSUE <='" + time_do+"'";
            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            if (data.Rows.Count < 1)
            {
                MessageBox.Show("Данных не найдено");
                return;
            }
            else
            {
                data.Columns[0].ColumnName = "Фамилия";
                data.Columns[1].ColumnName = "Имя";
                data.Columns[2].ColumnName = "Отчество";
                data.Columns[3].ColumnName = "Логин";
                data.Columns[4].ColumnName = "Номер подразделения";
                data.Columns[5].ColumnName = "Полное наименование";
                data.Columns[6].ColumnName = "Краткое наименование";
                data.Columns[7].ColumnName = "Номер Flash-накопителя";
                data.Columns[8].ColumnName = "Фирма Flash-накопителя";
                data.Columns[9].ColumnName = "Дата введения в эксплуатацию Flash-накопителя";
                data.Columns[10].ColumnName = "Время выдачи";
                data.Columns[11].ColumnName = "Крайнее время сдачи";
                data.Columns[12].ColumnName = "Время приема";
                dataGridView1.DataSource = data;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            
            PrintShow pf = new PrintShow();
            pf.Show();

            string time_ot = DateOt.Text + " 00:00:00";
            string time_do = DateDo.Text + " 23:59:59";
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT * FROM TAKE WHERE TIME_ISSUE >= '" + time_ot + "' AND TIME_ISSUE <='" + time_do + "'";
            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            Print_rpt pr = new Print_rpt();
            pr.SetDataSource(data);
            pf.crystalReportViewer1.ReportSource = pr;
            pf.crystalReportViewer1.Refresh();

            connection.Close();


            

           

        
        }
    }
}
