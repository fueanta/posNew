namespace Forms
{
    partial class FoodViews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodViews));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.table = new MetroFramework.Controls.MetroGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.radioNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioYes = new MaterialSkin.Controls.MaterialRadioButton();
            this.stockBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.chargesBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.browseBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.descriptionBox = new MetroFramework.Controls.MetroTextBox();
            this.typeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.discountBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.priceBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.infoGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.table);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox4.Location = new System.Drawing.Point(32, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 457);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Foods";
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
            this.table.Size = new System.Drawing.Size(562, 408);
            this.table.TabIndex = 18;
            this.table.SelectionChanged += new System.EventHandler(this.table_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(399, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.TabIndex = 59;
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
            this.searchBox.Location = new System.Drawing.Point(429, 34);
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
            this.searchBox.TabIndex = 58;
            this.searchBox.UseSelectable = true;
            this.searchBox.WaterMark = "Search here ...";
            this.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Tomato;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(378, 565);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(165, 46);
            this.deleteBtn.TabIndex = 57;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(773, 565);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(165, 46);
            this.updateBtn.TabIndex = 56;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.createBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createBtn.Location = new System.Drawing.Point(121, 565);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(165, 46);
            this.createBtn.TabIndex = 55;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // infoGroup
            // 
            this.infoGroup.Controls.Add(this.radioNo);
            this.infoGroup.Controls.Add(this.radioYes);
            this.infoGroup.Controls.Add(this.stockBox);
            this.infoGroup.Controls.Add(this.metroLabel5);
            this.infoGroup.Controls.Add(this.chargesBox);
            this.infoGroup.Controls.Add(this.metroLabel6);
            this.infoGroup.Controls.Add(this.browseBtn);
            this.infoGroup.Controls.Add(this.groupBox3);
            this.infoGroup.Controls.Add(this.typeComboBox);
            this.infoGroup.Controls.Add(this.metroLabel7);
            this.infoGroup.Controls.Add(this.discountBox);
            this.infoGroup.Controls.Add(this.metroLabel8);
            this.infoGroup.Controls.Add(this.metroLabel3);
            this.infoGroup.Controls.Add(this.priceBox);
            this.infoGroup.Controls.Add(this.metroLabel2);
            this.infoGroup.Controls.Add(this.nameBox);
            this.infoGroup.Controls.Add(this.metroLabel1);
            this.infoGroup.Controls.Add(this.groupBox2);
            this.infoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.infoGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoGroup.Location = new System.Drawing.Point(650, 34);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(672, 493);
            this.infoGroup.TabIndex = 54;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Food Information";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Depth = 0;
            this.radioNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioNo.Location = new System.Drawing.Point(244, 432);
            this.radioNo.Margin = new System.Windows.Forms.Padding(0);
            this.radioNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioNo.Name = "radioNo";
            this.radioNo.Ripple = true;
            this.radioNo.Size = new System.Drawing.Size(52, 30);
            this.radioNo.TabIndex = 65;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Depth = 0;
            this.radioYes.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioYes.Location = new System.Drawing.Point(160, 432);
            this.radioYes.Margin = new System.Windows.Forms.Padding(0);
            this.radioYes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioYes.Name = "radioYes";
            this.radioYes.Ripple = true;
            this.radioYes.Size = new System.Drawing.Size(59, 30);
            this.radioYes.TabIndex = 64;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // stockBox
            // 
            // 
            // 
            // 
            this.stockBox.CustomButton.Image = null;
            this.stockBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.stockBox.CustomButton.Name = "";
            this.stockBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.stockBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.stockBox.CustomButton.TabIndex = 1;
            this.stockBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stockBox.CustomButton.UseSelectable = true;
            this.stockBox.CustomButton.Visible = false;
<<<<<<< HEAD
=======
            this.stockBox.Enabled = false;
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
            this.stockBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.stockBox.Lines = new string[0];
            this.stockBox.Location = new System.Drawing.Point(160, 372);
            this.stockBox.MaxLength = 32767;
            this.stockBox.Name = "stockBox";
            this.stockBox.PasswordChar = '\0';
            this.stockBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stockBox.SelectedText = "";
            this.stockBox.SelectionLength = 0;
            this.stockBox.SelectionStart = 0;
            this.stockBox.ShortcutsEnabled = true;
            this.stockBox.Size = new System.Drawing.Size(162, 30);
            this.stockBox.TabIndex = 63;
            this.stockBox.UseSelectable = true;
            this.stockBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stockBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(16, 372);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 25);
            this.metroLabel5.TabIndex = 62;
            this.metroLabel5.Text = "Stock Count";
            // 
            // chargesBox
            // 
            // 
            // 
            // 
            this.chargesBox.CustomButton.Image = null;
            this.chargesBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.chargesBox.CustomButton.Name = "";
            this.chargesBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.chargesBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.chargesBox.CustomButton.TabIndex = 1;
            this.chargesBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chargesBox.CustomButton.UseSelectable = true;
            this.chargesBox.CustomButton.Visible = false;
            this.chargesBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.chargesBox.Lines = new string[0];
            this.chargesBox.Location = new System.Drawing.Point(160, 302);
            this.chargesBox.MaxLength = 32767;
            this.chargesBox.Name = "chargesBox";
            this.chargesBox.PasswordChar = '\0';
            this.chargesBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.chargesBox.SelectedText = "";
            this.chargesBox.SelectionLength = 0;
            this.chargesBox.SelectionStart = 0;
            this.chargesBox.ShortcutsEnabled = true;
            this.chargesBox.Size = new System.Drawing.Size(162, 30);
            this.chargesBox.TabIndex = 61;
            this.chargesBox.UseSelectable = true;
            this.chargesBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.chargesBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(16, 302);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(128, 25);
            this.metroLabel6.TabIndex = 60;
            this.metroLabel6.Text = "Other Charges";
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.browseBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.browseBtn.ForeColor = System.Drawing.Color.Black;
            this.browseBtn.Location = new System.Drawing.Point(450, 283);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(101, 36);
            this.browseBtn.Style = MetroFramework.MetroColorStyle.White;
            this.browseBtn.TabIndex = 59;
            this.browseBtn.Text = "Browse";
            this.browseBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.browseBtn.UseCustomBackColor = true;
            this.browseBtn.UseSelectable = true;
            this.browseBtn.UseStyleColors = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.descriptionBox);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Location = new System.Drawing.Point(351, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 115);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // descriptionBox
            // 
            // 
            // 
            // 
            this.descriptionBox.CustomButton.Image = null;
            this.descriptionBox.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.descriptionBox.CustomButton.Name = "";
            this.descriptionBox.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.descriptionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionBox.CustomButton.TabIndex = 1;
            this.descriptionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionBox.CustomButton.UseSelectable = true;
            this.descriptionBox.CustomButton.Visible = false;
            this.descriptionBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.descriptionBox.Lines = new string[0];
            this.descriptionBox.Location = new System.Drawing.Point(6, 26);
            this.descriptionBox.MaxLength = 32767;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.PasswordChar = '\0';
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionBox.SelectedText = "";
            this.descriptionBox.SelectionLength = 0;
            this.descriptionBox.SelectionStart = 0;
            this.descriptionBox.ShortcutsEnabled = true;
            this.descriptionBox.Size = new System.Drawing.Size(280, 83);
            this.descriptionBox.TabIndex = 42;
            this.descriptionBox.UseSelectable = true;
            this.descriptionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DisplayMember = "ID";
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.ItemHeight = 24;
            this.typeComboBox.Location = new System.Drawing.Point(160, 167);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(162, 30);
            this.typeComboBox.TabIndex = 56;
            this.typeComboBox.UseSelectable = true;
            this.typeComboBox.ValueMember = "ID";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(16, 432);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(96, 25);
            this.metroLabel7.TabIndex = 47;
            this.metroLabel7.Text = "Availability";
            // 
            // discountBox
            // 
            // 
            // 
            // 
            this.discountBox.CustomButton.Image = null;
            this.discountBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.discountBox.CustomButton.Name = "";
            this.discountBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.discountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.discountBox.CustomButton.TabIndex = 1;
            this.discountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.discountBox.CustomButton.UseSelectable = true;
            this.discountBox.CustomButton.Visible = false;
            this.discountBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.discountBox.Lines = new string[0];
            this.discountBox.Location = new System.Drawing.Point(160, 234);
            this.discountBox.MaxLength = 32767;
            this.discountBox.Name = "discountBox";
            this.discountBox.PasswordChar = '\0';
            this.discountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.discountBox.SelectedText = "";
            this.discountBox.SelectionLength = 0;
            this.discountBox.SelectionStart = 0;
            this.discountBox.ShortcutsEnabled = true;
            this.discountBox.Size = new System.Drawing.Size(162, 30);
            this.discountBox.TabIndex = 46;
            this.discountBox.UseSelectable = true;
            this.discountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.discountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(16, 234);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 25);
            this.metroLabel8.TabIndex = 45;
            this.metroLabel8.Text = "Discount";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(16, 167);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 25);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Type";
            // 
            // priceBox
            // 
            // 
            // 
            // 
            this.priceBox.CustomButton.Image = null;
            this.priceBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.priceBox.CustomButton.Name = "";
            this.priceBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.priceBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.priceBox.CustomButton.TabIndex = 1;
            this.priceBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.priceBox.CustomButton.UseSelectable = true;
            this.priceBox.CustomButton.Visible = false;
            this.priceBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.priceBox.Lines = new string[0];
            this.priceBox.Location = new System.Drawing.Point(160, 99);
            this.priceBox.MaxLength = 32767;
            this.priceBox.Name = "priceBox";
            this.priceBox.PasswordChar = '\0';
            this.priceBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceBox.SelectedText = "";
            this.priceBox.SelectionLength = 0;
            this.priceBox.SelectionStart = 0;
            this.priceBox.ShortcutsEnabled = true;
            this.priceBox.Size = new System.Drawing.Size(162, 30);
            this.priceBox.TabIndex = 40;
            this.priceBox.UseSelectable = true;
            this.priceBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(16, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 25);
            this.metroLabel2.TabIndex = 39;
            this.metroLabel2.Text = "Price";
            // 
            // nameBox
            // 
            // 
            // 
            // 
            this.nameBox.CustomButton.Image = null;
            this.nameBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.nameBox.CustomButton.Name = "";
            this.nameBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.nameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameBox.CustomButton.TabIndex = 1;
            this.nameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameBox.CustomButton.UseSelectable = true;
            this.nameBox.CustomButton.Visible = false;
            this.nameBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nameBox.Lines = new string[0];
            this.nameBox.Location = new System.Drawing.Point(160, 33);
            this.nameBox.MaxLength = 32767;
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameBox.SelectedText = "";
            this.nameBox.SelectionLength = 0;
            this.nameBox.SelectionStart = 0;
            this.nameBox.ShortcutsEnabled = true;
            this.nameBox.Size = new System.Drawing.Size(162, 30);
            this.nameBox.TabIndex = 38;
            this.nameBox.UseSelectable = true;
            this.nameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(16, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 25);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Location = new System.Drawing.Point(382, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 246);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(222, 219);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.BackColor = System.Drawing.Color.Orchid;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.inventoryBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventoryBtn.Location = new System.Drawing.Point(1034, 565);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(165, 46);
            this.inventoryBtn.TabIndex = 61;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = false;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // FoodViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 653);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.infoGroup);
            this.MaximizeBox = false;
            this.Name = "FoodViews";
            this.Text = "Food Items";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroGrid table;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox searchBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.GroupBox infoGroup;
        private MetroFramework.Controls.MetroButton browseBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox typeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox discountBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox priceBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox nameBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button inventoryBtn;
        private MaterialSkin.Controls.MaterialRadioButton radioNo;
        private MaterialSkin.Controls.MaterialRadioButton radioYes;
        private MetroFramework.Controls.MetroTextBox stockBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox chargesBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox descriptionBox;
    }
}