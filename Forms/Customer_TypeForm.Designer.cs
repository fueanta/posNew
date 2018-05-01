namespace Forms
{
    partial class Customer_TypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_TypeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.table = new MetroFramework.Controls.MetroGrid();
            this.salaryBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.jobTitileBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(518, 439);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(150, 50);
            this.updateBtn.TabIndex = 70;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Tomato;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(712, 439);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 50);
            this.deleteBtn.TabIndex = 69;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.createBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createBtn.Location = new System.Drawing.Point(325, 439);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(150, 50);
            this.createBtn.TabIndex = 68;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(361, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.searchBox.CustomButton.Image = null;
            this.searchBox.CustomButton.Location = new System.Drawing.Point(175, 2);
            this.searchBox.CustomButton.Name = "";
            this.searchBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBox.CustomButton.TabIndex = 1;
            this.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBox.CustomButton.UseSelectable = true;
            this.searchBox.CustomButton.Visible = false;
            this.searchBox.DisplayIcon = true;
            this.searchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(390, 34);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PromptText = "Search here ...";
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.ShowClearButton = true;
            this.searchBox.Size = new System.Drawing.Size(203, 30);
            this.searchBox.TabIndex = 66;
            this.searchBox.UseSelectable = true;
            this.searchBox.WaterMark = "Search here ...";
            this.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.table);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox4.Location = new System.Drawing.Point(32, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(561, 319);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Different Types";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle14;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.table.Location = new System.Drawing.Point(22, 31);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.table.RowTemplate.Height = 24;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(515, 266);
            this.table.TabIndex = 18;
            // 
            // salaryBox
            // 
            // 
            // 
            // 
            this.salaryBox.CustomButton.Image = null;
            this.salaryBox.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.salaryBox.CustomButton.Name = "";
            this.salaryBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.salaryBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salaryBox.CustomButton.TabIndex = 1;
            this.salaryBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salaryBox.CustomButton.UseSelectable = true;
            this.salaryBox.CustomButton.Visible = false;
            this.salaryBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.salaryBox.Lines = new string[0];
            this.salaryBox.Location = new System.Drawing.Point(172, 118);
            this.salaryBox.MaxLength = 32767;
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.PasswordChar = '\0';
            this.salaryBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salaryBox.SelectedText = "";
            this.salaryBox.SelectionLength = 0;
            this.salaryBox.SelectionStart = 0;
            this.salaryBox.ShortcutsEnabled = true;
            this.salaryBox.Size = new System.Drawing.Size(264, 30);
            this.salaryBox.TabIndex = 63;
            this.salaryBox.UseSelectable = true;
            this.salaryBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salaryBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(40, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 25);
            this.metroLabel2.TabIndex = 62;
            this.metroLabel2.Text = "Order Count";
            // 
            // jobTitileBox
            // 
            // 
            // 
            // 
            this.jobTitileBox.CustomButton.Image = null;
            this.jobTitileBox.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.jobTitileBox.CustomButton.Name = "";
            this.jobTitileBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.jobTitileBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jobTitileBox.CustomButton.TabIndex = 1;
            this.jobTitileBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jobTitileBox.CustomButton.UseSelectable = true;
            this.jobTitileBox.CustomButton.Visible = false;
            this.jobTitileBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.jobTitileBox.Lines = new string[0];
            this.jobTitileBox.Location = new System.Drawing.Point(172, 61);
            this.jobTitileBox.MaxLength = 32767;
            this.jobTitileBox.Name = "jobTitileBox";
            this.jobTitileBox.PasswordChar = '\0';
            this.jobTitileBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jobTitileBox.SelectedText = "";
            this.jobTitileBox.SelectionLength = 0;
            this.jobTitileBox.SelectionStart = 0;
            this.jobTitileBox.ShortcutsEnabled = true;
            this.jobTitileBox.Size = new System.Drawing.Size(264, 30);
            this.jobTitileBox.TabIndex = 61;
            this.jobTitileBox.UseSelectable = true;
            this.jobTitileBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jobTitileBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(40, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 25);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Type Ttile";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(172, 231);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(264, 30);
            this.metroTextBox1.TabIndex = 74;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(40, 231);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 25);
            this.metroLabel3.TabIndex = 73;
            this.metroLabel3.Text = "Discount";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(172, 174);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(264, 30);
            this.metroTextBox2.TabIndex = 72;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(40, 174);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 25);
            this.metroLabel4.TabIndex = 71;
            this.metroLabel4.Text = "Total Bills";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.jobTitileBox);
            this.groupBox1.Controls.Add(this.metroTextBox2);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.salaryBox);
            this.groupBox1.Location = new System.Drawing.Point(632, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 319);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Information";
            // 
            // Customer_TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.groupBox4);
            this.Name = "Customer_TypeForm";
            this.Text = "Customer Types";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox searchBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroGrid table;
        private MetroFramework.Controls.MetroTextBox salaryBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox jobTitileBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}