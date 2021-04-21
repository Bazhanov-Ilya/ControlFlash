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
    public partial class AddSubdivisionForm : Form
    {
        public AddSubdivisionForm()
        {
            InitializeComponent();

            IdSubdivisionBox.Text = "Номер";
            IdSubdivisionBox.ForeColor = Color.Gray;

            NameSubdivisionBox.Text = "Кратное название";
            NameSubdivisionBox.ForeColor = Color.Gray;

            FullNameSubdivisionBox.Text = "Полное название";
            FullNameSubdivisionBox.ForeColor = Color.Gray;

            TimeBox.Text = "Время выдачи";
            TimeBox.ForeColor = Color.Gray;
        }

        private void IdSubdivisionBox_Enter(object sender, EventArgs e)
        {
            if (IdSubdivisionBox.Text == "Номер")
            {
                IdSubdivisionBox.Text = "";
                IdSubdivisionBox.ForeColor = Color.Black;
            }
        }

        private void IdSubdivisionBox_Leave(object sender, EventArgs e)
        {
            if (IdSubdivisionBox.Text == "")
            {
                IdSubdivisionBox.Text = "Номер";
                IdSubdivisionBox.ForeColor = Color.Gray;
            }
        }

        private void NameSubdivisionBox_Enter(object sender, EventArgs e)
        {
            if (NameSubdivisionBox.Text == "Кратное название")
            {
                NameSubdivisionBox.Text = "";
                NameSubdivisionBox.ForeColor = Color.Black;
            }
        }

        private void NameSubdivisionBox_Leave(object sender, EventArgs e)
        {
            if (NameSubdivisionBox.Text == "")
            {
                NameSubdivisionBox.Text = "Кратное название";
                NameSubdivisionBox.ForeColor = Color.Gray;
            }
        }

        private void FullNameSubdivisionBox_Enter(object sender, EventArgs e)
        {
            if (FullNameSubdivisionBox.Text == "Полное название")
            {
                FullNameSubdivisionBox.Text = "";
                FullNameSubdivisionBox.ForeColor = Color.Black;
            }
        }

        private void FullNameSubdivisionBox_Leave(object sender, EventArgs e)
        {
            if (FullNameSubdivisionBox.Text == "")
            {
                FullNameSubdivisionBox.Text = "Полное название";
                FullNameSubdivisionBox.ForeColor = Color.Gray;
            }
        }

        private void TimeBox_Enter(object sender, EventArgs e)
        {
            if (TimeBox.Text == "Время выдачи")
            {
                TimeBox.Text = "";
                TimeBox.ForeColor = Color.Black;
            }
        }

        private void TimeBox_Leave(object sender, EventArgs e)
        {
            if (TimeBox.Text == "")
            {
                TimeBox.Text = "Время выдачи";
                TimeBox.ForeColor = Color.Gray;
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

        //кнопка добавления
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IdSubdivisionBox.Text == "Номер")
            {
                MessageBox.Show("Введите номер");
                return;
            }

            if (NameSubdivisionBox.Text == "Кратное название")
            {
                MessageBox.Show("Введите кратное название");
                return;
            }

            if (FullNameSubdivisionBox.Text == "Полное название")
            {
                MessageBox.Show("Введите полное название");
                return;
            }

            if (IsDataExists())
                return;
            string num = IdSubdivisionBox.Text;
            string name = NameSubdivisionBox.Text;
            string full_name = FullNameSubdivisionBox.Text;
            string times = TimeBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "INSERT INTO SUBDIVISION (ID, NUM, NAME, FULL_NAME) VALUES (subdivision_seq.nextval, '"+num+ "', '" + name + "', '" + full_name + "')";

            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавление успешно");
            }
            else
            {
                MessageBox.Show("Произошла ошибка добавления");
            }

            string sqls = "SELECT ID FROM SUBDIVISION WHERE NUM= '" + num + "' AND NAME= '" + name + "' AND FULL_NAME= '" + full_name + "'";
            command = new OracleCommand(sqls, connection);
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

            string sqli = "INSERT INTO TIMES (SUBDIVISION_ID, TIMES) VALUES ('" + id + "', '" + times + "')";
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
        public Boolean IsDataExists() {
            string num = IdSubdivisionBox.Text;
            string name = NameSubdivisionBox.Text;
            string full_name = FullNameSubdivisionBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT * FROM SUBDIVISION WHERE NUM= '" + num + "' OR NAME= '" + name + "' OR FULL_NAME= '" + full_name + "'";

            OracleCommand command = new OracleCommand(sql, connection);
            command.CommandType = CommandType.Text;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Введенные данные существуют");
                return true;
            }
            else
            {
                return false;
            }

           
        }
    }
}
