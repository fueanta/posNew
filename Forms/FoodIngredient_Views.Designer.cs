namespace Forms
{
    partial class FoodIngredient_Views
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check = new MetroFramework.Controls.MetroCheckBox();
            this.totalLabel = new MetroFramework.Controls.MetroLabel();
            this.changeBtn = new System.Windows.Forms.Button();
            this.amountBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.table = new MetroFramework.Controls.MetroGrid();
            this.discardBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.pushRight = new System.Windows.Forms.Button();
            this.pushLeft = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list);
            this.groupBox1.Location = new System.Drawing.Point(32, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unused Ingredients";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(22, 31);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(225, 356);
            this.list.TabIndex = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check);
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.changeBtn);
            this.groupBox2.Controls.Add(this.amountBox);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.table);
            this.groupBox2.Location = new System.Drawing.Point(434, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 433);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Used Ingredients";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.check.Location = new System.Drawing.Point(40, 373);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(186, 20);
            this.check.TabIndex = 61;
            this.check.Text = "Use Small(gm, litre) Unit";
            this.check.UseSelectable = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalLabel.Location = new System.Drawing.Point(22, 26);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(157, 25);
            this.totalLabel.TabIndex = 60;
            this.totalLabel.Text = "Inventory Value : ";
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.changeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeBtn.Location = new System.Drawing.Point(275, 376);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(90, 39);
            this.changeBtn.TabIndex = 59;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // amountBox
            // 
            // 
            // 
            // 
            this.amountBox.CustomButton.Image = null;
            this.amountBox.CustomButton.Location = new System.Drawing.Point(91, 2);
            this.amountBox.CustomButton.Name = "";
            this.amountBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.amountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountBox.CustomButton.TabIndex = 1;
            this.amountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountBox.CustomButton.UseSelectable = true;
            this.amountBox.CustomButton.Visible = false;
            this.amountBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.amountBox.Lines = new string[0];
            this.amountBox.Location = new System.Drawing.Point(137, 322);
            this.amountBox.MaxLength = 32767;
            this.amountBox.Name = "amountBox";
            this.amountBox.PasswordChar = '\0';
            this.amountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountBox.SelectedText = "";
            this.amountBox.SelectionLength = 0;
            this.amountBox.SelectionStart = 0;
            this.amountBox.ShortcutsEnabled = true;
            this.amountBox.Size = new System.Drawing.Size(119, 30);
            this.amountBox.TabIndex = 48;
            this.amountBox.UseSelectable = true;
            this.amountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(40, 322);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 25);
            this.metroLabel8.TabIndex = 47;
            this.metroLabel8.Text = "Amount";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
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
            this.table.Location = new System.Drawing.Point(6, 69);
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
            this.table.Size = new System.Drawing.Size(370, 235);
            this.table.TabIndex = 19;
            this.table.SelectionChanged += new System.EventHandler(this.table_SelectionChanged);
            // 
            // discardBtn
            // 
            this.discardBtn.BackColor = System.Drawing.Color.Tomato;
            this.discardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardBtn.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.discardBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.discardBtn.Location = new System.Drawing.Point(490, 519);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(165, 46);
            this.discardBtn.TabIndex = 59;
            this.discardBtn.Text = "Discard Changes";
            this.discardBtn.UseVisualStyleBackColor = false;
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(182, 519);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(165, 46);
            this.updateBtn.TabIndex = 58;
            this.updateBtn.Text = "Update Changes";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // pushRight
            // 
            this.pushRight.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pushRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pushRight.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.pushRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pushRight.Location = new System.Drawing.Point(338, 234);
            this.pushRight.Name = "pushRight";
            this.pushRight.Size = new System.Drawing.Size(61, 35);
            this.pushRight.TabIndex = 60;
            this.pushRight.Text = ">>";
            this.pushRight.UseVisualStyleBackColor = false;
            this.pushRight.Click += new System.EventHandler(this.pushRight_Click);
            // 
            // pushLeft
            // 
            this.pushLeft.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pushLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pushLeft.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.pushLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pushLeft.Location = new System.Drawing.Point(338, 294);
            this.pushLeft.Name = "pushLeft";
            this.pushLeft.Size = new System.Drawing.Size(61, 35);
            this.pushLeft.TabIndex = 61;
            this.pushLeft.Text = "<<";
            this.pushLeft.UseVisualStyleBackColor = false;
            this.pushLeft.Click += new System.EventHandler(this.pushLeft_Click);
            // 
            // FoodIngredient_Views
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 602);
            this.Controls.Add(this.pushLeft);
            this.Controls.Add(this.pushRight);
            this.Controls.Add(this.discardBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FoodIngredient_Views";
            this.Text = "Food - Ingredients [ Binding ]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button pushRight;
        private System.Windows.Forms.Button pushLeft;
        private MetroFramework.Controls.MetroTextBox amountBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Button changeBtn;
        private MetroFramework.Controls.MetroLabel totalLabel;
        private MetroFramework.Controls.MetroCheckBox check;
        private MetroFramework.Controls.MetroGrid table;
    }
}