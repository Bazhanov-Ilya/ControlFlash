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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        //Кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        //Кнопка перехлда к выдаче флеш-накопителя
        private void IssueButton_Click(object sender, EventArgs e)
        {
            Hide();
            IssueForm IssueForm = new IssueForm();
            IssueForm.Show();
        }

        //Кнопка перехлда к приему флеш-накопителя
        private void TakeButton_Click(object sender, EventArgs e)
        {
            Hide();
            TakeForm TakeForm = new TakeForm();
            TakeForm.Show();
        } 
        
        //Кнопка перехлда к приему флеш-накопителя
        private void UssersButton_Click(object sender, EventArgs e)
        {
            Hide();
            UsersForm UsersForm = new UsersForm();
            UsersForm.Show();
        }

        //Кнопка списка времени выдачи
        private void TimeButton_Click(object sender, EventArgs e)
        {
            Hide();
            TimeIssueForm TimeIssueForm = new TimeIssueForm();
            TimeIssueForm.Show();
        }

        //Кнопка списка флеш-накопителей
        private void FlashButton_Click(object sender, EventArgs e)
        {
            Hide();
            FlashForm FlashForm = new FlashForm();
            FlashForm.Show();
        }

        //Кнопка списка должников
        private void BlackListButton_Click(object sender, EventArgs e)
        {
            Hide();
            BlackListForm BlackListForm = new BlackListForm();
            BlackListForm.Show();
        }

        //Кнопка списка подразделений
        private void SubdivisionButton_Click(object sender, EventArgs e)
        {
            Hide();
            SubdivisionForm SubdivisionForm = new SubdivisionForm();
            SubdivisionForm.Show();
        }

        //Кнопка истории
        private void HistoryBotton_Click(object sender, EventArgs e)
        {
            Hide();
            HistoryForm HistoryForm = new HistoryForm();
            HistoryForm.Show();
        }
    }
}
