namespace Forms
{
    partial class PurchaseView
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
            this.totalLabel = new MetroFramework.Controls.MetroLabel();
            this.generateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.table = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fromTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.toTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.employeeBox = new MetroFramework.Controls.MetroTextBox();
            this.supplierBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.descriptionBox = new MetroFramework.Controls.MetroTextBox();
            this.totalBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.costBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.timeBox = new MetroFramework.Controls.MetroDateTime();
            this.discountBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalLabel.Location = new System.Drawing.Point(339, 577);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 25);
            this.totalLabel.TabIndex = 93;
            this.totalLabel.Text = "Cost :";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.generateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateBtn.Location = new System.Drawing.Point(232, 658);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(165, 46);
            this.generateBtn.TabIndex = 92;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Tomato;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(415, 658);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(165, 46);
            this.deleteBtn.TabIndex = 91;
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
            this.createBtn.Location = new System.Drawing.Point(48, 658);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(165, 46);
            this.createBtn.TabIndex = 90;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.table);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.Location = new System.Drawing.Point(29, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 492);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchases Within Time Range ";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.table.Location = new System.Drawing.Point(19, 31);
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
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.table.RowTemplate.Height = 24;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(532, 441);
            this.table.TabIndex = 18;
            this.table.SelectionChanged += new System.EventHandler(this.table_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fromTime);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.toTime);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Location = new System.Drawing.Point(638, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 134);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time Range";
            // 
            // fromTime
            // 
            this.fromTime.Location = new System.Drawing.Point(101, 31);
            this.fromTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.fromTime.Name = "fromTime";
            this.fromTime.Size = new System.Drawing.Size(200, 30);
            this.fromTime.TabIndex = 77;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(38, 81);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(30, 25);
            this.metroLabel9.TabIndex = 80;
            this.metroLabel9.Text = "To";
            // 
            // toTime
            // 
            this.toTime.Location = new System.Drawing.Point(101, 81);
            this.toTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.toTime.Name = "toTime";
            this.toTime.Size = new System.Drawing.Size(200, 30);
            this.toTime.TabIndex = 78;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(14, 31);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(54, 25);
            this.metroLabel8.TabIndex = 79;
            this.metroLabel8.Text = "From";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.employeeBox);
            this.groupBox3.Controls.Add(this.supplierBox);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.totalBox);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.costBox);
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.timeBox);
            this.groupBox3.Controls.Add(this.discountBox);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Location = new System.Drawing.Point(638, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 537);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Purchase Information";
            // 
            // employeeBox
            // 
            // 
            // 
            // 
            this.employeeBox.CustomButton.Image = null;
            this.employeeBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.employeeBox.CustomButton.Name = "";
            this.employeeBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.employeeBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.employeeBox.CustomButton.TabIndex = 1;
            this.employeeBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employeeBox.CustomButton.UseSelectable = true;
            this.employeeBox.CustomButton.Visible = false;
            this.employeeBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.employeeBox.Lines = new string[0];
            this.employeeBox.Location = new System.Drawing.Point(115, 102);
            this.employeeBox.MaxLength = 32767;
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.PasswordChar = '\0';
            this.employeeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employeeBox.SelectedText = "";
            this.employeeBox.SelectionLength = 0;
            this.employeeBox.SelectionStart = 0;
            this.employeeBox.ShortcutsEnabled = true;
            this.employeeBox.Size = new System.Drawing.Size(204, 30);
            this.employeeBox.TabIndex = 74;
            this.employeeBox.UseSelectable = true;
            this.employeeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employeeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // supplierBox
            // 
            // 
            // 
            // 
            this.supplierBox.CustomButton.Image = null;
            this.supplierBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.supplierBox.CustomButton.Name = "";
            this.supplierBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.supplierBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supplierBox.CustomButton.TabIndex = 1;
            this.supplierBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supplierBox.CustomButton.UseSelectable = true;
            this.supplierBox.CustomButton.Visible = false;
            this.supplierBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.supplierBox.Lines = new string[0];
            this.supplierBox.Location = new System.Drawing.Point(115, 164);
            this.supplierBox.MaxLength = 32767;
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.PasswordChar = '\0';
            this.supplierBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.supplierBox.SelectedText = "";
            this.supplierBox.SelectionLength = 0;
            this.supplierBox.SelectionStart = 0;
            this.supplierBox.ShortcutsEnabled = true;
            this.supplierBox.Size = new System.Drawing.Size(204, 30);
            this.supplierBox.TabIndex = 73;
            this.supplierBox.UseSelectable = true;
            this.supplierBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.supplierBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.descriptionBox);
            this.groupBox4.Location = new System.Drawing.Point(27, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 108);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Description";
            // 
            // descriptionBox
            // 
            // 
            // 
            // 
            this.descriptionBox.CustomButton.Image = null;
            this.descriptionBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.descriptionBox.CustomButton.Name = "";
            this.descriptionBox.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.descriptionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionBox.CustomButton.TabIndex = 1;
            this.descriptionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionBox.CustomButton.UseSelectable = true;
            this.descriptionBox.CustomButton.Visible = false;
            this.descriptionBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.descriptionBox.Lines = new string[0];
            this.descriptionBox.Location = new System.Drawing.Point(6, 21);
            this.descriptionBox.MaxLength = 32767;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.PasswordChar = '\0';
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionBox.SelectedText = "";
            this.descriptionBox.SelectionLength = 0;
            this.descriptionBox.SelectionStart = 0;
            this.descriptionBox.ShortcutsEnabled = true;
            this.descriptionBox.Size = new System.Drawing.Size(280, 81);
            this.descriptionBox.TabIndex = 72;
            this.descriptionBox.UseSelectable = true;
            this.descriptionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // totalBox
            // 
            // 
            // 
            // 
            this.totalBox.CustomButton.Image = null;
            this.totalBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.totalBox.CustomButton.Name = "";
            this.totalBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.totalBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalBox.CustomButton.TabIndex = 1;
            this.totalBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalBox.CustomButton.UseSelectable = true;
            this.totalBox.CustomButton.Visible = false;
            this.totalBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.totalBox.Lines = new string[0];
            this.totalBox.Location = new System.Drawing.Point(115, 349);
            this.totalBox.MaxLength = 32767;
            this.totalBox.Name = "totalBox";
            this.totalBox.PasswordChar = '\0';
            this.totalBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalBox.SelectedText = "";
            this.totalBox.SelectionLength = 0;
            this.totalBox.SelectionStart = 0;
            this.totalBox.ShortcutsEnabled = true;
            this.totalBox.Size = new System.Drawing.Size(204, 30);
            this.totalBox.TabIndex = 71;
            this.totalBox.UseSelectable = true;
            this.totalBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(20, 349);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 25);
            this.metroLabel7.TabIndex = 70;
            this.metroLabel7.Text = "Total";
            // 
            // costBox
            // 
            // 
            // 
            // 
            this.costBox.CustomButton.Image = null;
            this.costBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.costBox.CustomButton.Name = "";
            this.costBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.costBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.costBox.CustomButton.TabIndex = 1;
            this.costBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.costBox.CustomButton.UseSelectable = true;
            this.costBox.CustomButton.Visible = false;
            this.costBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.costBox.Lines = new string[0];
            this.costBox.Location = new System.Drawing.Point(115, 225);
            this.costBox.MaxLength = 32767;
            this.costBox.Name = "costBox";
            this.costBox.PasswordChar = '\0';
            this.costBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.costBox.SelectedText = "";
            this.costBox.SelectionLength = 0;
            this.costBox.SelectionStart = 0;
            this.costBox.ShortcutsEnabled = true;
            this.costBox.Size = new System.Drawing.Size(204, 30);
            this.costBox.TabIndex = 69;
            this.costBox.UseSelectable = true;
            this.costBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.costBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(20, 225);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 25);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "Cost";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(20, 164);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 25);
            this.metroLabel6.TabIndex = 65;
            this.metroLabel6.Text = "Supplier";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(115, 41);
            this.timeBox.MinimumSize = new System.Drawing.Size(0, 30);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(204, 30);
            this.timeBox.TabIndex = 63;
            // 
            // discountBox
            // 
            // 
            // 
            // 
            this.discountBox.CustomButton.Image = null;
            this.discountBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.discountBox.CustomButton.Name = "";
            this.discountBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.discountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.discountBox.CustomButton.TabIndex = 1;
            this.discountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.discountBox.CustomButton.UseSelectable = true;
            this.discountBox.CustomButton.Visible = false;
            this.discountBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.discountBox.Lines = new string[0];
            this.discountBox.Location = new System.Drawing.Point(115, 287);
            this.discountBox.MaxLength = 32767;
            this.discountBox.Name = "discountBox";
            this.discountBox.PasswordChar = '\0';
            this.discountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.discountBox.SelectedText = "";
            this.discountBox.SelectionLength = 0;
            this.discountBox.SelectionStart = 0;
            this.discountBox.ShortcutsEnabled = true;
            this.discountBox.Size = new System.Drawing.Size(204, 30);
            this.discountBox.TabIndex = 60;
            this.discountBox.UseSelectable = true;
            this.discountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.discountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(20, 287);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 25);
            this.metroLabel5.TabIndex = 59;
            this.metroLabel5.Text = "Discount";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(20, 41);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 25);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Time";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(20, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 25);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Employee";
            // 
            // PurchaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 758);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "PurchaseView";
            this.Text = "Purchases";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel totalLabel;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid table;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime fromTime;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime toTime;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox employeeBox;
        private MetroFramework.Controls.MetroTextBox supplierBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox descriptionBox;
        private MetroFramework.Controls.MetroTextBox totalBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox costBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime timeBox;
        private MetroFramework.Controls.MetroTextBox discountBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}