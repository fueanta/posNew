namespace Forms
{
    partial class Customer_TypeViews
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.table = new MetroFramework.Controls.MetroGrid();
            this.orderCountBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.typeTitleBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.discountBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.totalBillBox = new MetroFramework.Controls.MetroTextBox();
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
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
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
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.table.Location = new System.Drawing.Point(22, 31);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.table.RowTemplate.Height = 24;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(515, 266);
            this.table.TabIndex = 18;
            this.table.SelectionChanged += new System.EventHandler(this.table_SelectionChanged);
            // 
            // orderCountBox
            // 
            // 
            // 
            // 
            this.orderCountBox.CustomButton.Image = null;
            this.orderCountBox.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.orderCountBox.CustomButton.Name = "";
            this.orderCountBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.orderCountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.orderCountBox.CustomButton.TabIndex = 1;
            this.orderCountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.orderCountBox.CustomButton.UseSelectable = true;
            this.orderCountBox.CustomButton.Visible = false;
            this.orderCountBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.orderCountBox.Lines = new string[0];
            this.orderCountBox.Location = new System.Drawing.Point(172, 118);
            this.orderCountBox.MaxLength = 32767;
            this.orderCountBox.Name = "orderCountBox";
            this.orderCountBox.PasswordChar = '\0';
            this.orderCountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.orderCountBox.SelectedText = "";
            this.orderCountBox.SelectionLength = 0;
            this.orderCountBox.SelectionStart = 0;
            this.orderCountBox.ShortcutsEnabled = true;
            this.orderCountBox.Size = new System.Drawing.Size(264, 30);
            this.orderCountBox.TabIndex = 63;
            this.orderCountBox.UseSelectable = true;
            this.orderCountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.orderCountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // typeTitleBox
            // 
            // 
            // 
            // 
            this.typeTitleBox.CustomButton.Image = null;
            this.typeTitleBox.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.typeTitleBox.CustomButton.Name = "";
            this.typeTitleBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.typeTitleBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.typeTitleBox.CustomButton.TabIndex = 1;
            this.typeTitleBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.typeTitleBox.CustomButton.UseSelectable = true;
            this.typeTitleBox.CustomButton.Visible = false;
            this.typeTitleBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.typeTitleBox.Lines = new string[0];
            this.typeTitleBox.Location = new System.Drawing.Point(172, 61);
            this.typeTitleBox.MaxLength = 32767;
            this.typeTitleBox.Name = "typeTitleBox";
            this.typeTitleBox.PasswordChar = '\0';
            this.typeTitleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.typeTitleBox.SelectedText = "";
            this.typeTitleBox.SelectionLength = 0;
            this.typeTitleBox.SelectionStart = 0;
            this.typeTitleBox.ShortcutsEnabled = true;
            this.typeTitleBox.Size = new System.Drawing.Size(264, 30);
            this.typeTitleBox.TabIndex = 61;
            this.typeTitleBox.UseSelectable = true;
            this.typeTitleBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typeTitleBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // discountBox
            // 
            // 
            // 
            // 
            this.discountBox.CustomButton.Image = null;
            this.discountBox.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.discountBox.CustomButton.Name = "";
            this.discountBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.discountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.discountBox.CustomButton.TabIndex = 1;
            this.discountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.discountBox.CustomButton.UseSelectable = true;
            this.discountBox.CustomButton.Visible = false;
            this.discountBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.discountBox.Lines = new string[0];
            this.discountBox.Location = new System.Drawing.Point(172, 231);
            this.discountBox.MaxLength = 32767;
            this.discountBox.Name = "discountBox";
            this.discountBox.PasswordChar = '\0';
            this.discountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.discountBox.SelectedText = "";
            this.discountBox.SelectionLength = 0;
            this.discountBox.SelectionStart = 0;
            this.discountBox.ShortcutsEnabled = true;
            this.discountBox.Size = new System.Drawing.Size(264, 30);
            this.discountBox.TabIndex = 74;
            this.discountBox.UseSelectable = true;
            this.discountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.discountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // totalBillBox
            // 
            // 
            // 
            // 
            this.totalBillBox.CustomButton.Image = null;
            this.totalBillBox.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.totalBillBox.CustomButton.Name = "";
            this.totalBillBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.totalBillBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalBillBox.CustomButton.TabIndex = 1;
            this.totalBillBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalBillBox.CustomButton.UseSelectable = true;
            this.totalBillBox.CustomButton.Visible = false;
            this.totalBillBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.totalBillBox.Lines = new string[0];
            this.totalBillBox.Location = new System.Drawing.Point(172, 174);
            this.totalBillBox.MaxLength = 32767;
            this.totalBillBox.Name = "totalBillBox";
            this.totalBillBox.PasswordChar = '\0';
            this.totalBillBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalBillBox.SelectedText = "";
            this.totalBillBox.SelectionLength = 0;
            this.totalBillBox.SelectionStart = 0;
            this.totalBillBox.ShortcutsEnabled = true;
            this.totalBillBox.Size = new System.Drawing.Size(264, 30);
            this.totalBillBox.TabIndex = 72;
            this.totalBillBox.UseSelectable = true;
            this.totalBillBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalBillBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.groupBox1.Controls.Add(this.discountBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.typeTitleBox);
            this.groupBox1.Controls.Add(this.totalBillBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.orderCountBox);
            this.groupBox1.Location = new System.Drawing.Point(632, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 319);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Information";
            // 
            // Customer_TypeViews
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
            this.MaximizeBox = false;
            this.Name = "Customer_TypeViews";
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
        private MetroFramework.Controls.MetroTextBox orderCountBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox typeTitleBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox discountBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox totalBillBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}