namespace Forms
{
    partial class CreateChangelog
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
            this.employeeBox = new MetroFramework.Controls.MetroTextBox();
            this.DescriptionBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeBox
            // 
            // 
            // 
            // 
            this.employeeBox.CustomButton.Image = null;
            this.employeeBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.employeeBox.CustomButton.Name = "";
            this.employeeBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.employeeBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.employeeBox.CustomButton.TabIndex = 1;
            this.employeeBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employeeBox.CustomButton.UseSelectable = true;
            this.employeeBox.CustomButton.Visible = false;
            this.employeeBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.employeeBox.Lines = new string[0];
            this.employeeBox.Location = new System.Drawing.Point(175, 156);
            this.employeeBox.MaxLength = 32767;
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.PasswordChar = '\0';
            this.employeeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employeeBox.SelectedText = "";
            this.employeeBox.SelectionLength = 0;
            this.employeeBox.SelectionStart = 0;
            this.employeeBox.ShortcutsEnabled = true;
            this.employeeBox.Size = new System.Drawing.Size(162, 30);
            this.employeeBox.TabIndex = 65;
            this.employeeBox.UseSelectable = true;
            this.employeeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employeeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DescriptionBox
            // 
            // 
            // 
            // 
            this.DescriptionBox.CustomButton.Image = null;
            this.DescriptionBox.CustomButton.Location = new System.Drawing.Point(124, 2);
            this.DescriptionBox.CustomButton.Name = "";
            this.DescriptionBox.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.DescriptionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescriptionBox.CustomButton.TabIndex = 1;
            this.DescriptionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescriptionBox.CustomButton.UseSelectable = true;
            this.DescriptionBox.CustomButton.Visible = false;
            this.DescriptionBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.DescriptionBox.Lines = new string[0];
            this.DescriptionBox.Location = new System.Drawing.Point(146, 219);
            this.DescriptionBox.MaxLength = 32767;
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.PasswordChar = '\0';
            this.DescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionBox.SelectedText = "";
            this.DescriptionBox.SelectionLength = 0;
            this.DescriptionBox.SelectionStart = 0;
            this.DescriptionBox.ShortcutsEnabled = true;
            this.DescriptionBox.Size = new System.Drawing.Size(210, 88);
            this.DescriptionBox.TabIndex = 61;
            this.DescriptionBox.UseSelectable = true;
            this.DescriptionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescriptionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(31, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 25);
            this.metroLabel2.TabIndex = 64;
            this.metroLabel2.Text = "Employee ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(31, 219);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 25);
            this.metroLabel3.TabIndex = 60;
            this.metroLabel3.Text = "Description";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.Location = new System.Drawing.Point(290, 398);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(165, 46);
            this.cancelBtn.TabIndex = 67;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.createBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createBtn.Location = new System.Drawing.Point(31, 398);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(165, 46);
            this.createBtn.TabIndex = 66;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // CreateChangelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 555);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.MaximizeBox = false;
            this.Name = "CreateChangelog";
            this.Text = "CreateChangelog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox employeeBox;
        private MetroFramework.Controls.MetroTextBox DescriptionBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
    }
}