namespace Forms
{
    partial class CreateJob
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
            this.salaryBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.jobTitileBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salaryBox
            // 
            // 
            // 
            // 
            this.salaryBox.CustomButton.Image = null;
            this.salaryBox.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.salaryBox.CustomButton.Name = "";
            this.salaryBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.salaryBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salaryBox.CustomButton.TabIndex = 1;
            this.salaryBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salaryBox.CustomButton.UseSelectable = true;
            this.salaryBox.CustomButton.Visible = false;
            this.salaryBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.salaryBox.Lines = new string[0];
            this.salaryBox.Location = new System.Drawing.Point(138, 142);
            this.salaryBox.MaxLength = 32767;
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.PasswordChar = '\0';
            this.salaryBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salaryBox.SelectedText = "";
            this.salaryBox.SelectionLength = 0;
            this.salaryBox.SelectionStart = 0;
            this.salaryBox.ShortcutsEnabled = true;
            this.salaryBox.Size = new System.Drawing.Size(210, 30);
            this.salaryBox.TabIndex = 16;
            this.salaryBox.UseSelectable = true;
            this.salaryBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salaryBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(38, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Salary";
            // 
            // jobTitileBox
            // 
            // 
            // 
            // 
            this.jobTitileBox.CustomButton.Image = null;
            this.jobTitileBox.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.jobTitileBox.CustomButton.Name = "";
            this.jobTitileBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.jobTitileBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jobTitileBox.CustomButton.TabIndex = 1;
            this.jobTitileBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jobTitileBox.CustomButton.UseSelectable = true;
            this.jobTitileBox.CustomButton.Visible = false;
            this.jobTitileBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.jobTitileBox.Lines = new string[0];
            this.jobTitileBox.Location = new System.Drawing.Point(138, 85);
            this.jobTitileBox.MaxLength = 32767;
            this.jobTitileBox.Name = "jobTitileBox";
            this.jobTitileBox.PasswordChar = '\0';
            this.jobTitileBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jobTitileBox.SelectedText = "";
            this.jobTitileBox.SelectionLength = 0;
            this.jobTitileBox.SelectionStart = 0;
            this.jobTitileBox.ShortcutsEnabled = true;
            this.jobTitileBox.Size = new System.Drawing.Size(210, 30);
            this.jobTitileBox.TabIndex = 14;
            this.jobTitileBox.UseSelectable = true;
            this.jobTitileBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jobTitileBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(38, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 25);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Job Title";
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.createBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createBtn.Location = new System.Drawing.Point(29, 350);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(150, 50);
            this.createBtn.TabIndex = 29;
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
            this.cancelBtn.Location = new System.Drawing.Point(192, 350);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 50);
            this.cancelBtn.TabIndex = 30;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(15, 26);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(294, 91);
            this.descriptionBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Location = new System.Drawing.Point(23, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 134);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // CreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 429);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.jobTitileBox);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "CreateJob";
            this.Text = " Create a new Job";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox salaryBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox jobTitileBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}