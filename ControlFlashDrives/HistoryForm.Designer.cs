
namespace ControlFlashDrives
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.DateDo = new System.Windows.Forms.DateTimePicker();
            this.DateOt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.topWindow = new System.Windows.Forms.Label();
            this.closeButon = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(184)))), ((int)(((byte)(190)))));
            this.mainPanel.Controls.Add(this.DateDo);
            this.mainPanel.Controls.Add(this.DateOt);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.closeButon);
            this.mainPanel.Controls.Add(this.LoadButton);
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1360, 558);
            this.mainPanel.TabIndex = 6;
            // 
            // DateDo
            // 
            this.DateDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDo.Location = new System.Drawing.Point(257, 104);
            this.DateDo.Name = "DateDo";
            this.DateDo.Size = new System.Drawing.Size(94, 20);
            this.DateDo.TabIndex = 8;
            // 
            // DateOt
            // 
            this.DateOt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOt.Location = new System.Drawing.Point(111, 104);
            this.DateOt.Name = "DateOt";
            this.DateOt.Size = new System.Drawing.Size(97, 20);
            this.DateOt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(214, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата от";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1209, 508);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 38);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(3)))));
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Controls.Add(this.topWindow);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1360, 90);
            this.topPanel.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1338, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 20);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButon_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButon_MouseLeave);
            // 
            // topWindow
            // 
            this.topWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.topWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topWindow.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topWindow.ForeColor = System.Drawing.Color.White;
            this.topWindow.Location = new System.Drawing.Point(0, 0);
            this.topWindow.Name = "topWindow";
            this.topWindow.Size = new System.Drawing.Size(1360, 90);
            this.topWindow.TabIndex = 0;
            this.topWindow.Text = "История выдачи и приема flash-накопителей";
            this.topWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopWindow_MouseDown);
            this.topWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopWindow_MouseMove);
            // 
            // closeButon
            // 
            this.closeButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButon.ForeColor = System.Drawing.Color.White;
            this.closeButon.Location = new System.Drawing.Point(778, 0);
            this.closeButon.Name = "closeButon";
            this.closeButon.Size = new System.Drawing.Size(22, 20);
            this.closeButon.TabIndex = 3;
            this.closeButon.Text = "X";
            this.closeButon.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.Location = new System.Drawing.Point(370, 96);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(139, 38);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1343, 362);
            this.dataGridView1.TabIndex = 6;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 558);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label topWindow;
        private System.Windows.Forms.Label closeButon;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.DateTimePicker DateDo;
        private System.Windows.Forms.DateTimePicker DateOt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}