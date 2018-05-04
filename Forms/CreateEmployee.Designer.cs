namespace Forms
{
    partial class CreateEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hireDateTime = new MetroFramework.Controls.MetroDateTime();
            this.jobComboBox = new MetroFramework.Controls.MetroComboBox();
            this.browseBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.passBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.commissionBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.addressBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.emailBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.contactBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.authorityBox = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.authorityBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.jobComboBox);
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.passBox);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.commissionBox);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.addressBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.contactBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(61, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 495);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hireDateTime);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Location = new System.Drawing.Point(351, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 63);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hire date";
            // 
            // hireDateTime
            // 
            this.hireDateTime.Location = new System.Drawing.Point(6, 21);
            this.hireDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.hireDateTime.Name = "hireDateTime";
            this.hireDateTime.Size = new System.Drawing.Size(280, 30);
            this.hireDateTime.TabIndex = 57;
            // 
            // jobComboBox
            // 
            this.jobComboBox.DisplayMember = "ID";
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.ItemHeight = 24;
            this.jobComboBox.Location = new System.Drawing.Point(160, 319);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(162, 30);
            this.jobComboBox.TabIndex = 56;
            this.jobComboBox.UseSelectable = true;
            this.jobComboBox.ValueMember = "ID";
            this.jobComboBox.SelectedIndexChanged += new System.EventHandler(this.jobComboBox_SelectedIndexChanged);
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.browseBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.browseBtn.ForeColor = System.Drawing.Color.Black;
            this.browseBtn.Location = new System.Drawing.Point(448, 298);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(101, 36);
            this.browseBtn.Style = MetroFramework.MetroColorStyle.White;
            this.browseBtn.TabIndex = 55;
            this.browseBtn.Text = "Browse";
            this.browseBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.browseBtn.UseCustomBackColor = true;
            this.browseBtn.UseSelectable = true;
            this.browseBtn.UseStyleColors = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(16, 435);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 25);
            this.metroLabel5.TabIndex = 51;
            this.metroLabel5.Text = "Authority";
            // 
            // passBox
            // 
            // 
            // 
            // 
            this.passBox.CustomButton.Image = null;
            this.passBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.passBox.CustomButton.Name = "";
            this.passBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.passBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passBox.CustomButton.TabIndex = 1;
            this.passBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passBox.CustomButton.UseSelectable = true;
            this.passBox.CustomButton.Visible = false;
            this.passBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passBox.Lines = new string[0];
            this.passBox.Location = new System.Drawing.Point(160, 378);
            this.passBox.MaxLength = 32767;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '\0';
            this.passBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.ShortcutsEnabled = true;
            this.passBox.Size = new System.Drawing.Size(162, 30);
            this.passBox.TabIndex = 50;
            this.passBox.UseSelectable = true;
            this.passBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(16, 378);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 25);
            this.metroLabel6.TabIndex = 49;
            this.metroLabel6.Text = "Password";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(16, 321);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 25);
            this.metroLabel7.TabIndex = 47;
            this.metroLabel7.Text = "Job";
            // 
            // commissionBox
            // 
            // 
            // 
            // 
            this.commissionBox.CustomButton.Image = null;
            this.commissionBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.commissionBox.CustomButton.Name = "";
            this.commissionBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.commissionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.commissionBox.CustomButton.TabIndex = 1;
            this.commissionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.commissionBox.CustomButton.UseSelectable = true;
            this.commissionBox.CustomButton.Visible = false;
            this.commissionBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.commissionBox.Lines = new string[0];
            this.commissionBox.Location = new System.Drawing.Point(160, 264);
            this.commissionBox.MaxLength = 32767;
            this.commissionBox.Name = "commissionBox";
            this.commissionBox.PasswordChar = '\0';
            this.commissionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.commissionBox.SelectedText = "";
            this.commissionBox.SelectionLength = 0;
            this.commissionBox.SelectionStart = 0;
            this.commissionBox.ShortcutsEnabled = true;
            this.commissionBox.Size = new System.Drawing.Size(162, 30);
            this.commissionBox.TabIndex = 46;
            this.commissionBox.UseSelectable = true;
            this.commissionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.commissionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(16, 264);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(110, 25);
            this.metroLabel8.TabIndex = 45;
            this.metroLabel8.Text = "Commission";
            // 
            // addressBox
            // 
            // 
            // 
            // 
            this.addressBox.CustomButton.Image = null;
            this.addressBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.addressBox.CustomButton.Name = "";
            this.addressBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.addressBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addressBox.CustomButton.TabIndex = 1;
            this.addressBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addressBox.CustomButton.UseSelectable = true;
            this.addressBox.CustomButton.Visible = false;
            this.addressBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.addressBox.Lines = new string[0];
            this.addressBox.Location = new System.Drawing.Point(160, 204);
            this.addressBox.MaxLength = 32767;
            this.addressBox.Name = "addressBox";
            this.addressBox.PasswordChar = '\0';
            this.addressBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressBox.SelectedText = "";
            this.addressBox.SelectionLength = 0;
            this.addressBox.SelectionStart = 0;
            this.addressBox.ShortcutsEnabled = true;
            this.addressBox.Size = new System.Drawing.Size(162, 30);
            this.addressBox.TabIndex = 44;
            this.addressBox.UseSelectable = true;
            this.addressBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addressBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(16, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 25);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Address";
            // 
            // emailBox
            // 
            // 
            // 
            // 
            this.emailBox.CustomButton.Image = null;
            this.emailBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.emailBox.CustomButton.Name = "";
            this.emailBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.emailBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailBox.CustomButton.TabIndex = 1;
            this.emailBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailBox.CustomButton.UseSelectable = true;
            this.emailBox.CustomButton.Visible = false;
            this.emailBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailBox.Lines = new string[0];
            this.emailBox.Location = new System.Drawing.Point(160, 147);
            this.emailBox.MaxLength = 32767;
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailBox.SelectedText = "";
            this.emailBox.SelectionLength = 0;
            this.emailBox.SelectionStart = 0;
            this.emailBox.ShortcutsEnabled = true;
            this.emailBox.Size = new System.Drawing.Size(162, 30);
            this.emailBox.TabIndex = 42;
            this.emailBox.UseSelectable = true;
            this.emailBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(16, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 25);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Email";
            // 
            // contactBox
            // 
            // 
            // 
            // 
            this.contactBox.CustomButton.Image = null;
            this.contactBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.contactBox.CustomButton.Name = "";
            this.contactBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.contactBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.contactBox.CustomButton.TabIndex = 1;
            this.contactBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.contactBox.CustomButton.UseSelectable = true;
            this.contactBox.CustomButton.Visible = false;
            this.contactBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.contactBox.Lines = new string[0];
            this.contactBox.Location = new System.Drawing.Point(160, 90);
            this.contactBox.MaxLength = 32767;
            this.contactBox.Name = "contactBox";
            this.contactBox.PasswordChar = '\0';
            this.contactBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contactBox.SelectedText = "";
            this.contactBox.SelectionLength = 0;
            this.contactBox.SelectionStart = 0;
            this.contactBox.ShortcutsEnabled = true;
            this.contactBox.Size = new System.Drawing.Size(162, 30);
            this.contactBox.TabIndex = 40;
            this.contactBox.UseSelectable = true;
            this.contactBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.contactBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(16, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 25);
            this.metroLabel2.TabIndex = 39;
            this.metroLabel2.Text = "Contact No";
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
            this.nameBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
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
            this.groupBox2.Location = new System.Drawing.Point(382, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 256);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 220);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.createBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createBtn.Location = new System.Drawing.Point(161, 604);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(165, 46);
            this.createBtn.TabIndex = 32;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.Location = new System.Drawing.Point(468, 604);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(165, 46);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // authorityBox
            // 
            this.authorityBox.DisplayMember = "ID";
            this.authorityBox.FormattingEnabled = true;
            this.authorityBox.ItemHeight = 24;
            this.authorityBox.Location = new System.Drawing.Point(160, 435);
            this.authorityBox.Name = "authorityBox";
            this.authorityBox.Size = new System.Drawing.Size(162, 30);
            this.authorityBox.TabIndex = 59;
            this.authorityBox.UseSelectable = true;
            this.authorityBox.ValueMember = "ID";
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 679);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CreateEmployee";
            this.Text = "Create New Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroDateTime hireDateTime;
        private MetroFramework.Controls.MetroComboBox jobComboBox;
        private MetroFramework.Controls.MetroButton browseBtn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox passBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox commissionBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox addressBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox emailBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox contactBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox nameBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private MetroFramework.Controls.MetroComboBox authorityBox;
    }
}