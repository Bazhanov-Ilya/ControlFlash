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
    public partial class SubdivisionForm : Form
    {
        public SubdivisionForm()
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

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddSubdivisionForm AddSubdivisionForm = new AddSubdivisionForm();
            AddSubdivisionForm.Show();
        }

        private void DelUserButton_Click(object sender, EventArgs e)
        {
            Hide();
            DelSubdivisionForm DelSubdivisionForm = new DelSubdivisionForm();
            DelSubdivisionForm.Show();
        }

        private void SubdivisionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "controlFlash.SUBDIVISION". При необходимости она может быть перемещена или удалена.
            this.sUBDIVISIONTableAdapter.Fill(this.controlFlash.SUBDIVISION);

        }
    }
}
