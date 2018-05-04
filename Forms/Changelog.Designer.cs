namespace Forms
{
    partial class Changelog
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
            this.table = new MetroFramework.Controls.MetroGrid();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.DescriptionBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.employeeBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.idBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToResizeRows = false;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.table.Location = new System.Drawing.Point(23, 63);
            this.table.Name = "table";
            this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.table.RowTemplate.Height = 24;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(398, 337);
            this.table.Style = MetroFramework.MetroColorStyle.Lime;
            this.table.TabIndex = 0;
            this.table.Click += new System.EventHandler(this.table_SelectionChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Tomato;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(303, 530);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(165, 46);
            this.deleteBtn.TabIndex = 53;
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
            this.updateBtn.Location = new System.Drawing.Point(529, 530);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(165, 46);
            this.updateBtn.TabIndex = 52;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newBtn.Location = new System.Drawing.Point(46, 530);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(165, 46);
            this.newBtn.TabIndex = 51;
            this.newBtn.Text = "Create";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
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
            this.DescriptionBox.Location = new System.Drawing.Point(129, 179);
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
            this.DescriptionBox.TabIndex = 55;
            this.DescriptionBox.UseSelectable = true;
            this.DescriptionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescriptionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(14, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 25);
            this.metroLabel3.TabIndex = 54;
            this.metroLabel3.Text = "Description";
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
            this.employeeBox.Location = new System.Drawing.Point(158, 116);
            this.employeeBox.MaxLength = 32767;
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.PasswordChar = '\0';
            this.employeeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employeeBox.SelectedText = "";
            this.employeeBox.SelectionLength = 0;
            this.employeeBox.SelectionStart = 0;
            this.employeeBox.ShortcutsEnabled = true;
            this.employeeBox.Size = new System.Drawing.Size(162, 30);
            this.employeeBox.TabIndex = 59;
            this.employeeBox.UseSelectable = true;
            this.employeeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employeeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(14, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 25);
            this.metroLabel2.TabIndex = 58;
            this.metroLabel2.Text = "Employee ID";
            // 
            // idBox
            // 
            // 
            // 
            // 
            this.idBox.CustomButton.Image = null;
            this.idBox.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.idBox.CustomButton.Name = "";
            this.idBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.idBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idBox.CustomButton.TabIndex = 1;
            this.idBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idBox.CustomButton.UseSelectable = true;
            this.idBox.CustomButton.Visible = false;
            this.idBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.idBox.Lines = new string[0];
            this.idBox.Location = new System.Drawing.Point(591, 103);
            this.idBox.MaxLength = 32767;
            this.idBox.Name = "idBox";
            this.idBox.PasswordChar = '\0';
            this.idBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idBox.SelectedText = "";
            this.idBox.SelectionLength = 0;
            this.idBox.SelectionStart = 0;
            this.idBox.ShortcutsEnabled = true;
            this.idBox.Size = new System.Drawing.Size(162, 30);
            this.idBox.TabIndex = 57;
            this.idBox.UseSelectable = true;
            this.idBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(447, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 25);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeBox);
            this.groupBox1.Controls.Add(this.DescriptionBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(433, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 383);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Changelog Details";
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 656);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.table);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Changelog";
            this.Text = "Changelog";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid table;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button newBtn;
        private MetroFramework.Controls.MetroTextBox DescriptionBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox employeeBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox idBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}