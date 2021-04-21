
namespace ControlFlashDrives
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.topWindow = new System.Windows.Forms.Label();
            this.closeButon = new System.Windows.Forms.Label();
            this.RefreshPassButton = new System.Windows.Forms.Button();
            this.DelUserButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.controlFlash = new ControlFlashDrives.ControlFlash();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new ControlFlashDrives.ControlFlashTableAdapters.USERSTableAdapter();
            this.controlFlash1 = new ControlFlashDrives.ControlFlash();
            this.uSERSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlFlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlFlash1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(184)))), ((int)(((byte)(190)))));
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.closeButon);
            this.mainPanel.Controls.Add(this.RefreshPassButton);
            this.mainPanel.Controls.Add(this.DelUserButton);
            this.mainPanel.Controls.Add(this.RegistrationButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(820, 585);
            this.mainPanel.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 477);
            this.dataGridView1.TabIndex = 6;
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
            this.backButton.Location = new System.Drawing.Point(671, 535);
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
            this.topPanel.Size = new System.Drawing.Size(820, 90);
            this.topPanel.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(798, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 20);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.Enter += new System.EventHandler(this.CloseButon_MouseEnter);
            this.closeButton.Leave += new System.EventHandler(this.CloseButon_MouseLeave);
            // 
            // topWindow
            // 
            this.topWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.topWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topWindow.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topWindow.ForeColor = System.Drawing.Color.White;
            this.topWindow.Location = new System.Drawing.Point(0, 0);
            this.topWindow.Name = "topWindow";
            this.topWindow.Size = new System.Drawing.Size(820, 90);
            this.topWindow.TabIndex = 0;
            this.topWindow.Text = "Пользователи";
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
            // RefreshPassButton
            // 
            this.RefreshPassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.RefreshPassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshPassButton.FlatAppearance.BorderSize = 0;
            this.RefreshPassButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.RefreshPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshPassButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.RefreshPassButton.ForeColor = System.Drawing.Color.White;
            this.RefreshPassButton.Location = new System.Drawing.Point(671, 248);
            this.RefreshPassButton.Name = "RefreshPassButton";
            this.RefreshPassButton.Size = new System.Drawing.Size(139, 51);
            this.RefreshPassButton.TabIndex = 2;
            this.RefreshPassButton.Text = "Изменить пароль";
            this.RefreshPassButton.UseVisualStyleBackColor = false;
            this.RefreshPassButton.Click += new System.EventHandler(this.RefreshPassButton_Click);
            // 
            // DelUserButton
            // 
            this.DelUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.DelUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelUserButton.FlatAppearance.BorderSize = 0;
            this.DelUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.DelUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelUserButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.DelUserButton.ForeColor = System.Drawing.Color.White;
            this.DelUserButton.Location = new System.Drawing.Point(671, 174);
            this.DelUserButton.Name = "DelUserButton";
            this.DelUserButton.Size = new System.Drawing.Size(139, 51);
            this.DelUserButton.TabIndex = 2;
            this.DelUserButton.Text = "Удалить";
            this.DelUserButton.UseVisualStyleBackColor = false;
            this.DelUserButton.Click += new System.EventHandler(this.DelUserButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationButton.FlatAppearance.BorderSize = 0;
            this.RegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrationButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.RegistrationButton.ForeColor = System.Drawing.Color.White;
            this.RegistrationButton.Location = new System.Drawing.Point(671, 103);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(139, 51);
            this.RegistrationButton.TabIndex = 2;
            this.RegistrationButton.Text = "Добавить ";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // controlFlash
            // 
            this.controlFlash.DataSetName = "ControlFlash";
            this.controlFlash.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource1
            // 
            this.uSERSBindingSource1.DataMember = "USERS";
            this.uSERSBindingSource1.DataSource = this.controlFlash;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // controlFlash1
            // 
            this.controlFlash1.DataSetName = "ControlFlash";
            this.controlFlash1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource2
            // 
            this.uSERSBindingSource2.DataMember = "USERS";
            this.uSERSBindingSource2.DataSource = this.controlFlash1;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 585);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UssersForm";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlFlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlFlash1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label topWindow;
        private System.Windows.Forms.Label closeButon;
        private System.Windows.Forms.Button RefreshPassButton;
        private System.Windows.Forms.Button DelUserButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private ControlFlash controlFlash;
        private System.Windows.Forms.BindingSource uSERSBindingSource1;
        private ControlFlashTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlFlash controlFlash1;
        private System.Windows.Forms.BindingSource uSERSBindingSource2;
    }
}