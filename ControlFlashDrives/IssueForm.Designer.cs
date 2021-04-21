
namespace ControlFlashDrives
{
    partial class IssueForm
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
            this.IssueButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.idFlashBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(184)))), ((int)(((byte)(190)))));
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.closeButon);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.IssueButton);
            this.mainPanel.Controls.Add(this.logBox);
            this.mainPanel.Controls.Add(this.idFlashBox);
            this.mainPanel.Controls.Add(this.pictureBox4);
            this.mainPanel.Controls.Add(this.pictureBox3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(391, 368);
            this.mainPanel.TabIndex = 3;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(3)))));
            this.topPanel.Controls.Add(this.topWindow);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(391, 90);
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
            this.topWindow.Size = new System.Drawing.Size(391, 90);
            this.topWindow.TabIndex = 0;
            this.topWindow.Text = "Выдать флеш-накопитель";
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
            this.backButton.Location = new System.Drawing.Point(236, 312);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 38);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // IssueButton
            // 
            this.IssueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.IssueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IssueButton.FlatAppearance.BorderSize = 0;
            this.IssueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.IssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IssueButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.IssueButton.ForeColor = System.Drawing.Color.White;
            this.IssueButton.Location = new System.Drawing.Point(105, 243);
            this.IssueButton.Name = "IssueButton";
            this.IssueButton.Size = new System.Drawing.Size(183, 51);
            this.IssueButton.TabIndex = 2;
            this.IssueButton.Text = "Выдать";
            this.IssueButton.UseVisualStyleBackColor = false;
            this.IssueButton.Click += new System.EventHandler(this.IssueButton_Click);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.Location = new System.Drawing.Point(68, 102);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(307, 48);
            this.logBox.TabIndex = 1;
            this.logBox.Enter += new System.EventHandler(this.LogBox_Enter);
            this.logBox.Leave += new System.EventHandler(this.LogBox_Leave);
            // 
            // idFlashBox
            // 
            this.idFlashBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFlashBox.Location = new System.Drawing.Point(68, 178);
            this.idFlashBox.Name = "idFlashBox";
            this.idFlashBox.Size = new System.Drawing.Size(307, 48);
            this.idFlashBox.TabIndex = 1;
            this.idFlashBox.Enter += new System.EventHandler(this.IdFlashBox_Enter);
            this.idFlashBox.Leave += new System.EventHandler(this.IdFlashBox_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ControlFlashDrives.Properties.Resources.USB;
            this.pictureBox4.Location = new System.Drawing.Point(12, 176);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ControlFlashDrives.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(12, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 368);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topWindow;
        private System.Windows.Forms.Label closeButon;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button IssueButton;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox idFlashBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}