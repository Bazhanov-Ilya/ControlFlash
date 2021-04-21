
namespace ControlFlashDrives
{
    partial class RegistrationForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.topWindow = new System.Windows.Forms.Label();
            this.closeButon = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.midNameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.passRepeatBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.subdivisionNumberBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(184)))), ((int)(((byte)(190)))));
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.closeButon);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.AddButton);
            this.mainPanel.Controls.Add(this.logBox);
            this.mainPanel.Controls.Add(this.passBox);
            this.mainPanel.Controls.Add(this.midNameBox);
            this.mainPanel.Controls.Add(this.nameBox);
            this.mainPanel.Controls.Add(this.surnameBox);
            this.mainPanel.Controls.Add(this.pictureBox4);
            this.mainPanel.Controls.Add(this.passRepeatBox);
            this.mainPanel.Controls.Add(this.phoneBox);
            this.mainPanel.Controls.Add(this.subdivisionNumberBox);
            this.mainPanel.Controls.Add(this.pictureBox3);
            this.mainPanel.Controls.Add(this.pictureBox8);
            this.mainPanel.Controls.Add(this.pictureBox6);
            this.mainPanel.Controls.Add(this.pictureBox7);
            this.mainPanel.Controls.Add(this.pictureBox5);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(703, 572);
            this.mainPanel.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(3)))));
            this.topPanel.Controls.Add(this.topWindow);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(703, 90);
            this.topPanel.TabIndex = 4;
            // 
            // topWindow
            // 
            this.topWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.topWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topWindow.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topWindow.ForeColor = System.Drawing.Color.White;
            this.topWindow.Location = new System.Drawing.Point(0, 0);
            this.topWindow.Name = "topWindow";
            this.topWindow.Size = new System.Drawing.Size(703, 90);
            this.topWindow.TabIndex = 0;
            this.topWindow.Text = "Добавить нового пользователя";
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
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(552, 522);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 38);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(275, 466);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 51);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.Location = new System.Drawing.Point(426, 151);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(233, 48);
            this.logBox.TabIndex = 1;
            this.logBox.Enter += new System.EventHandler(this.LogBox_Enter);
            this.logBox.Leave += new System.EventHandler(this.LogBox_Leave);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(426, 227);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(233, 48);
            this.passBox.TabIndex = 1;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.passBox.Leave += new System.EventHandler(this.PassBox_Leave);
            // 
            // midNameBox
            // 
            this.midNameBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.midNameBox.Location = new System.Drawing.Point(100, 309);
            this.midNameBox.Name = "midNameBox";
            this.midNameBox.Size = new System.Drawing.Size(233, 48);
            this.midNameBox.TabIndex = 1;
            this.midNameBox.Enter += new System.EventHandler(this.MidNmeBox_Enter);
            this.midNameBox.Leave += new System.EventHandler(this.MidNameBox_Leave);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(100, 227);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(233, 48);
            this.nameBox.TabIndex = 1;
            this.nameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(100, 151);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(233, 48);
            this.surnameBox.TabIndex = 1;
            this.surnameBox.Enter += new System.EventHandler(this.SurnameBox_Enter);
            this.surnameBox.Leave += new System.EventHandler(this.SurnameBox_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ControlFlashDrives.Properties.Resources.pass;
            this.pictureBox4.Location = new System.Drawing.Point(370, 225);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // passRepeatBox
            // 
            this.passRepeatBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passRepeatBox.Location = new System.Drawing.Point(426, 309);
            this.passRepeatBox.Name = "passRepeatBox";
            this.passRepeatBox.Size = new System.Drawing.Size(233, 48);
            this.passRepeatBox.TabIndex = 1;
            this.passRepeatBox.UseSystemPasswordChar = true;
            this.passRepeatBox.Enter += new System.EventHandler(this.PassRepeatBox_Enter);
            this.passRepeatBox.Leave += new System.EventHandler(this.PassRepeatBox_Leave);
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(100, 384);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(233, 48);
            this.phoneBox.TabIndex = 1;
            this.phoneBox.Enter += new System.EventHandler(this.PhoneBox_Enter);
            this.phoneBox.Leave += new System.EventHandler(this.PhoneBox_Leave);
            // 
            // subdivisionNumberBox
            // 
            this.subdivisionNumberBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subdivisionNumberBox.Location = new System.Drawing.Point(426, 384);
            this.subdivisionNumberBox.Name = "subdivisionNumberBox";
            this.subdivisionNumberBox.Size = new System.Drawing.Size(233, 48);
            this.subdivisionNumberBox.TabIndex = 1;
            this.subdivisionNumberBox.Enter += new System.EventHandler(this.SubdivisionNumberBox_Enter);
            this.subdivisionNumberBox.Leave += new System.EventHandler(this.SubdivisionNumberBox_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ControlFlashDrives.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(370, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ControlFlashDrives.Properties.Resources.subdivision;
            this.pictureBox8.Location = new System.Drawing.Point(370, 382);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ControlFlashDrives.Properties.Resources.phone;
            this.pictureBox6.Location = new System.Drawing.Point(44, 384);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ControlFlashDrives.Properties.Resources.pass;
            this.pictureBox7.Location = new System.Drawing.Point(370, 305);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ControlFlashDrives.Properties.Resources.name;
            this.pictureBox5.Location = new System.Drawing.Point(44, 307);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlFlashDrives.Properties.Resources.name;
            this.pictureBox2.Location = new System.Drawing.Point(44, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlFlashDrives.Properties.Resources.name;
            this.pictureBox1.Location = new System.Drawing.Point(44, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 572);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrationForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeButon;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topWindow;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passRepeatBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox subdivisionNumberBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox midNameBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}