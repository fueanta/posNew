namespace Forms
{
    partial class OrderView
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.employeeBox = new MetroFramework.Controls.MetroTextBox();
            this.cardBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.otherBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.descriptionBox = new MetroFramework.Controls.MetroTextBox();
            this.totalBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.billBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timeBox = new MetroFramework.Controls.MetroDateTime();
            this.discountBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.fromTime = new MetroFramework.Controls.MetroDateTime();
            this.toTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.table = new MetroFramework.Controls.MetroGrid();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.totalLabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.employeeBox);
            this.groupBox3.Controls.Add(this.cardBox);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.otherBox);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.totalBox);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.billBox);
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.timeBox);
            this.groupBox3.Controls.Add(this.discountBox);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Location = new System.Drawing.Point(641, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 566);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Information";
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
            this.employeeBox.Enabled = false;
            this.employeeBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.employeeBox.Lines = new string[0];
            this.employeeBox.Location = new System.Drawing.Point(115, 95);
            this.employeeBox.MaxLength = 32767;
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.PasswordChar = '\0';
            this.employeeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employeeBox.SelectedText = "";
            this.employeeBox.SelectionLength = 0;
            this.employeeBox.SelectionStart = 0;
            this.employeeBox.ShortcutsEnabled = true;
            this.employeeBox.Size = new System.Drawing.Size(204, 30);
            this.employeeBox.TabIndex = 77;
            this.employeeBox.UseSelectable = true;
            this.employeeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employeeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cardBox
            // 
            // 
            // 
            // 
            this.cardBox.CustomButton.Image = null;
            this.cardBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.cardBox.CustomButton.Name = "";
            this.cardBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.cardBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cardBox.CustomButton.TabIndex = 1;
            this.cardBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cardBox.CustomButton.UseSelectable = true;
            this.cardBox.CustomButton.Visible = false;
            this.cardBox.Enabled = false;
            this.cardBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.cardBox.Lines = new string[0];
            this.cardBox.Location = new System.Drawing.Point(115, 381);
            this.cardBox.MaxLength = 32767;
            this.cardBox.Name = "cardBox";
            this.cardBox.PasswordChar = '\0';
            this.cardBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cardBox.SelectedText = "";
            this.cardBox.SelectionLength = 0;
            this.cardBox.SelectionStart = 0;
            this.cardBox.ShortcutsEnabled = true;
            this.cardBox.Size = new System.Drawing.Size(204, 30);
            this.cardBox.TabIndex = 76;
            this.cardBox.UseSelectable = true;
            this.cardBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cardBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(20, 381);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 25);
            this.metroLabel6.TabIndex = 75;
            this.metroLabel6.Text = "Card No.";
            // 
            // otherBox
            // 
            // 
            // 
            // 
            this.otherBox.CustomButton.Image = null;
            this.otherBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.otherBox.CustomButton.Name = "";
            this.otherBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.otherBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.otherBox.CustomButton.TabIndex = 1;
            this.otherBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.otherBox.CustomButton.UseSelectable = true;
            this.otherBox.CustomButton.Visible = false;
            this.otherBox.Enabled = false;
            this.otherBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.otherBox.Lines = new string[0];
            this.otherBox.Location = new System.Drawing.Point(115, 267);
            this.otherBox.MaxLength = 32767;
            this.otherBox.Name = "otherBox";
            this.otherBox.PasswordChar = '\0';
            this.otherBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.otherBox.SelectedText = "";
            this.otherBox.SelectionLength = 0;
            this.otherBox.SelectionStart = 0;
            this.otherBox.ShortcutsEnabled = true;
            this.otherBox.Size = new System.Drawing.Size(204, 30);
            this.otherBox.TabIndex = 74;
            this.otherBox.UseSelectable = true;
            this.otherBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.otherBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(20, 267);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 25);
            this.metroLabel3.TabIndex = 73;
            this.metroLabel3.Text = "Others";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.descriptionBox);
            this.groupBox4.Location = new System.Drawing.Point(27, 430);
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
            this.descriptionBox.Enabled = false;
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
            this.totalBox.Enabled = false;
            this.totalBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.totalBox.Lines = new string[0];
            this.totalBox.Location = new System.Drawing.Point(115, 324);
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
            this.metroLabel7.Location = new System.Drawing.Point(20, 324);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 25);
            this.metroLabel7.TabIndex = 70;
            this.metroLabel7.Text = "Total";
            // 
            // billBox
            // 
            // 
            // 
            // 
            this.billBox.CustomButton.Image = null;
            this.billBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.billBox.CustomButton.Name = "";
            this.billBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.billBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.billBox.CustomButton.TabIndex = 1;
            this.billBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.billBox.CustomButton.UseSelectable = true;
            this.billBox.CustomButton.Visible = false;
            this.billBox.Enabled = false;
            this.billBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.billBox.Lines = new string[0];
            this.billBox.Location = new System.Drawing.Point(115, 152);
            this.billBox.MaxLength = 32767;
            this.billBox.Name = "billBox";
            this.billBox.PasswordChar = '\0';
            this.billBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.billBox.SelectedText = "";
            this.billBox.SelectionLength = 0;
            this.billBox.SelectionStart = 0;
            this.billBox.ShortcutsEnabled = true;
            this.billBox.Size = new System.Drawing.Size(204, 30);
            this.billBox.TabIndex = 69;
            this.billBox.UseSelectable = true;
            this.billBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.billBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(20, 152);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 25);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "Bill";
            // 
            // timeBox
            // 
            this.timeBox.Enabled = false;
            this.timeBox.Location = new System.Drawing.Point(115, 39);
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
            this.discountBox.Enabled = false;
            this.discountBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.discountBox.Lines = new string[0];
            this.discountBox.Location = new System.Drawing.Point(115, 209);
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
            this.metroLabel5.Location = new System.Drawing.Point(20, 209);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 25);
            this.metroLabel5.TabIndex = 59;
            this.metroLabel5.Text = "Discount";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(20, 39);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 25);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Time";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(20, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 25);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Employer";
            // 
            // fromTime
            // 
            this.fromTime.Location = new System.Drawing.Point(101, 31);
            this.fromTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.fromTime.Name = "fromTime";
            this.fromTime.Size = new System.Drawing.Size(200, 30);
            this.fromTime.TabIndex = 77;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fromTime);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.toTime);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Location = new System.Drawing.Point(641, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 134);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time Range";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.table);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.Location = new System.Drawing.Point(32, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 510);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders Within Time Range ";
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
            this.table.Size = new System.Drawing.Size(532, 459);
            this.table.TabIndex = 18;
            this.table.SelectionChanged += new System.EventHandler(this.table_SelectionChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Tomato;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(418, 660);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(165, 46);
            this.deleteBtn.TabIndex = 84;
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
            this.createBtn.Location = new System.Drawing.Point(51, 660);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(165, 46);
            this.createBtn.TabIndex = 83;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.generateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateBtn.Location = new System.Drawing.Point(235, 660);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(165, 46);
            this.generateBtn.TabIndex = 85;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalLabel.Location = new System.Drawing.Point(302, 593);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(98, 25);
            this.totalLabel.TabIndex = 86;
            this.totalLabel.Text = "Revenue :";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 763);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "OrderView";
            this.Text = "Orders";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox cardBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox otherBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox descriptionBox;
        private MetroFramework.Controls.MetroTextBox totalBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox billBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime timeBox;
        private MetroFramework.Controls.MetroTextBox discountBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime fromTime;
        private MetroFramework.Controls.MetroDateTime toTime;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid table;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button generateBtn;
        private MetroFramework.Controls.MetroLabel totalLabel;
        private MetroFramework.Controls.MetroTextBox employeeBox;
    }
}