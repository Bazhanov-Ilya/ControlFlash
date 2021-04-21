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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            logBox.Text = "Логин";
            logBox.ForeColor = Color.Gray;
            passBox.Text = "Пароль";
            passBox.ForeColor = Color.Gray;

        }

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


        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

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

        private void PassBox_Enter(object sender, EventArgs e)
        {
            if (passBox.Text == "Пароль")
            {
                passBox.Text = "";
                passBox.ForeColor = Color.Black;
            }
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (passBox.Text == "")
            {
                passBox.Text = "Пароль";
                passBox.ForeColor = Color.Gray;
            }
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = logBox.Text;
            string pass = passBox.Text;
            string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";
            
            OracleConnection connection = new OracleConnection(con);
            connection.Open();

            string sql = "SELECT * FROM AUTHORIZATION WHERE LOGIN='"+login+"' AND PASSWORD='"+pass+"'";

            OracleCommand command = new OracleCommand(sql,connection);
            command.CommandType = CommandType.Text;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

              if (table.Rows.Count > 0)
              {
                VerificationMechanism.Check();
                Hide();
                MainForm MainForm = new MainForm();
                MainForm.Show(); 
            }
            else
            {
                MessageBox.Show("Неверый логин или пароль, попробуйте снова");
            }

            connection.Close();
        }


    }
}
