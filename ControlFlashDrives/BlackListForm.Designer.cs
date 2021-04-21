
namespace ControlFlashDrives
{
    partial class BlackListForm
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
            this.ReListButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topWindow = new System.Windows.Forms.Label();
            this.closeButon = new System.Windows.Forms.Label();
            this.bLACKLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlFlash = new ControlFlashDrives.ControlFlash();
            this.controlFlashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLACK_LISTTableAdapter = new ControlFlashDrives.ControlFlashTableAdapters.BLACK_LISTTableAdapter();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bLACKLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlFlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlFlashBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(184)))), ((int)(((byte)(190)))));
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Controls.Add(this.ReListButton);
            this.mainPanel.Controls.Add(this.BackButton);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.closeButon);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(897, 600);
            this.mainPanel.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 477);
            this.dataGridView1.TabIndex = 9;
            // 
            // ReListButton
            // 
            this.ReListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.ReListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReListButton.FlatAppearance.BorderSize = 0;
            this.ReListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.ReListButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReListButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.ReListButton.ForeColor = System.Drawing.Color.White;
            this.ReListButton.Location = new System.Drawing.Point(671, 111);
            this.ReListButton.Name = "ReListButton";
            this.ReListButton.Size = new System.Drawing.Size(200, 50);
            this.ReListButton.TabIndex = 8;
            this.ReListButton.Text = "Изменить";
            this.ReListButton.UseVisualStyleBackColor = false;
            this.ReListButton.Click += new System.EventHandler(this.ReListButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(72)))), ((int)(((byte)(11)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(751, 553);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 35);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(3)))));
            this.topPanel.Controls.Add(this.topWindow);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(897, 90);
            this.topPanel.TabIndex = 4;
            // 
            // topWindow
            // 
            this.topWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.topWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topWindow.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topWindow.ForeColor = System.Drawing.Color.White;
            this.topWindow.Location = new System.Drawing.Point(0, 0);
            this.topWindow.Margin = new System.Windows.Forms.Padding(0);
            this.topWindow.Name = "topWindow";
            this.topWindow.Size = new System.Drawing.Size(897, 90);
            this.topWindow.TabIndex = 0;
            this.topWindow.Text = "Должники";
            this.topWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButon
            // 
            this.closeButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButon.ForeColor = System.Drawing.Color.White;
            this.closeButon.Location = new System.Drawing.Point(-32768, 0);
            this.closeButon.Margin = new System.Windows.Forms.Padding(0);
            this.closeButon.Name = "closeButon";
            this.closeButon.Size = new System.Drawing.Size(0, 20);
            this.closeButon.TabIndex = 3;
            this.closeButon.Text = "X";
            this.closeButon.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bLACKLISTBindingSource
            // 
            this.bLACKLISTBindingSource.DataMember = "BLACK_LIST";
            this.bLACKLISTBindingSource.DataSource = this.controlFlash;
            // 
            // controlFlash
            // 
            this.controlFlash.DataSetName = "ControlFlash";
            this.controlFlash.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlFlashBindingSource
            // 
            this.controlFlashBindingSource.DataSource = this.controlFlash;
            this.controlFlashBindingSource.Position = 0;
            // 
            // bLACK_LISTTableAdapter
            // 
            this.bLACK_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // BlackListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 600);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "BlackListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackListForm";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bLACKLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlFlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlFlashBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topWindow;
        private System.Windows.Forms.Label closeButon;
        private System.Windows.Forms.BindingSource controlFlashBindingSource;
        private ControlFlash controlFlash;
        private System.Windows.Forms.BindingSource bLACKLISTBindingSource;
        private ControlFlashTableAdapters.BLACK_LISTTableAdapter bLACK_LISTTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ReListButton;
    }
}