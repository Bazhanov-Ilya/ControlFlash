
namespace ControlFlashDrives
{
    partial class AddFlashForm
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
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topWindow = new System.Windows.Forms.Label();
            this.closeButon = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FirmBox = new System.Windows.Forms.TextBox();
            this.IdFlashBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(184)))), ((int)(((byte)(190)))));
            this.mainPanel.Controls.Add(this.DateBox);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.closeButon);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.AddButton);
            this.mainPanel.Controls.Add(this.FirmBox);
            this.mainPanel.Controls.Add(this.IdFlashBox);
            this.mainPanel.Controls.Add(this.pictureBox3);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(398, 507);
            this.mainPanel.TabIndex = 3;
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBox.Location = new System.Drawing.Point(100, 313);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(269, 39);
            this.DateBox.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(3)))));
            this.topPanel.Controls.Add(this.topWindow);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(398, 90);
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
            this.topWindow.Size = new System.Drawing.Size(398, 90);
            this.topWindow.TabIndex = 0;
            this.topWindow.Text = "Добавить флеш-накопитель";
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
            this.backButton.Location = new System.Drawing.Point(247, 456);
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
            this.AddButton.Location = new System.Drawing.Point(100, 382);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 51);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FirmBox
            // 
            this.FirmBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirmBox.Location = new System.Drawing.Point(100, 227);
            this.FirmBox.Name = "FirmBox";
            this.FirmBox.Size = new System.Drawing.Size(269, 48);
            this.FirmBox.TabIndex = 1;
            this.FirmBox.Enter += new System.EventHandler(this.FirmBox_Enter);
            this.FirmBox.Leave += new System.EventHandler(this.FirmBox_Leave);
            // 
            // IdFlashBox
            // 
            this.IdFlashBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdFlashBox.Location = new System.Drawing.Point(100, 151);
            this.IdFlashBox.Name = "IdFlashBox";
            this.IdFlashBox.Size = new System.Drawing.Size(269, 48);
            this.IdFlashBox.TabIndex = 1;
            this.IdFlashBox.Enter += new System.EventHandler(this.IdFlashBox_Enter);
            this.IdFlashBox.Leave += new System.EventHandler(this.IdFlashBox_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ControlFlashDrives.Properties.Resources.time;
            this.pictureBox3.Location = new System.Drawing.Point(30, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlFlashDrives.Properties.Resources.firm;
            this.pictureBox2.Location = new System.Drawing.Point(30, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlFlashDrives.Properties.Resources.USB;
            this.pictureBox1.Location = new System.Drawing.Point(30, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddFlashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 507);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFlashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFlashForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topWindow;
        private System.Windows.Forms.Label closeButon;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox FirmBox;
        private System.Windows.Forms.TextBox IdFlashBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}