namespace Forms
{
    partial class HomePage
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
            this.tileJobs = new MetroFramework.Controls.MetroTile();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.tileIngredients = new MetroFramework.Controls.MetroTile();
            this.tileFoods = new MetroFramework.Controls.MetroTile();
            this.tilePayment = new MetroFramework.Controls.MetroTile();
            this.tileEmployees = new MetroFramework.Controls.MetroTile();
            this.tileCustomerType = new MetroFramework.Controls.MetroTile();
            this.tileCustomer = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileJobs
            // 
            this.tileJobs.ActiveControl = null;
            this.tileJobs.Location = new System.Drawing.Point(383, 314);
            this.tileJobs.Name = "tileJobs";
            this.tileJobs.Size = new System.Drawing.Size(203, 164);
            this.tileJobs.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileJobs.TabIndex = 32;
            this.tileJobs.Text = "Jobs";
            this.tileJobs.UseSelectable = true;
            this.tileJobs.Click += new System.EventHandler(this.tileJobs_Click);
            // 
            // tileLogout
            // 
            this.tileLogout.ActiveControl = null;
            this.tileLogout.Location = new System.Drawing.Point(592, 314);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(159, 164);
            this.tileLogout.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLogout.TabIndex = 31;
            this.tileLogout.Text = "LOGOUT";
            this.tileLogout.UseSelectable = true;
            // 
            // tileIngredients
            // 
            this.tileIngredients.ActiveControl = null;
            this.tileIngredients.Location = new System.Drawing.Point(213, 314);
            this.tileIngredients.Name = "tileIngredients";
            this.tileIngredients.Size = new System.Drawing.Size(164, 164);
            this.tileIngredients.Style = MetroFramework.MetroColorStyle.Green;
            this.tileIngredients.TabIndex = 28;
            this.tileIngredients.Text = "Ingredients";
            this.tileIngredients.UseSelectable = true;
            this.tileIngredients.Click += new System.EventHandler(this.tileIngredients_Click);
            // 
            // tileFoods
            // 
            this.tileFoods.ActiveControl = null;
            this.tileFoods.Location = new System.Drawing.Point(49, 314);
            this.tileFoods.Name = "tileFoods";
            this.tileFoods.Size = new System.Drawing.Size(158, 164);
            this.tileFoods.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileFoods.TabIndex = 30;
            this.tileFoods.Text = "Food Items";
            this.tileFoods.UseSelectable = true;
            this.tileFoods.Click += new System.EventHandler(this.tileFoods_Click);
            // 
            // tilePayment
            // 
            this.tilePayment.ActiveControl = null;
            this.tilePayment.Location = new System.Drawing.Point(606, 109);
            this.tilePayment.Name = "tilePayment";
            this.tilePayment.Size = new System.Drawing.Size(145, 168);
            this.tilePayment.Style = MetroFramework.MetroColorStyle.Red;
            this.tilePayment.TabIndex = 29;
            this.tilePayment.Text = "Payroll";
            this.tilePayment.UseSelectable = true;
            this.tilePayment.Click += new System.EventHandler(this.tilePayment_Click);
            // 
            // tileEmployees
            // 
            this.tileEmployees.ActiveControl = null;
            this.tileEmployees.Location = new System.Drawing.Point(423, 109);
            this.tileEmployees.Name = "tileEmployees";
            this.tileEmployees.Size = new System.Drawing.Size(177, 168);
            this.tileEmployees.TabIndex = 27;
            this.tileEmployees.Text = "Employees";
            this.tileEmployees.UseSelectable = true;
            this.tileEmployees.Click += new System.EventHandler(this.tileEmployees_Click);
            // 
            // tileCustomerType
            // 
            this.tileCustomerType.ActiveControl = null;
            this.tileCustomerType.Location = new System.Drawing.Point(252, 109);
            this.tileCustomerType.Name = "tileCustomerType";
            this.tileCustomerType.Size = new System.Drawing.Size(165, 168);
            this.tileCustomerType.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tileCustomerType.TabIndex = 26;
            this.tileCustomerType.Text = "Customer Type";
            this.tileCustomerType.UseSelectable = true;
            this.tileCustomerType.Click += new System.EventHandler(this.tileCustomerType_Click);
            // 
            // tileCustomer
            // 
            this.tileCustomer.ActiveControl = null;
            this.tileCustomer.Location = new System.Drawing.Point(49, 109);
            this.tileCustomer.Name = "tileCustomer";
            this.tileCustomer.Size = new System.Drawing.Size(197, 168);
            this.tileCustomer.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileCustomer.TabIndex = 25;
            this.tileCustomer.Text = "Customer";
            this.tileCustomer.UseSelectable = true;
            this.tileCustomer.Click += new System.EventHandler(this.tileCustomer_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 594);
            this.Controls.Add(this.tileJobs);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.tileIngredients);
            this.Controls.Add(this.tileFoods);
            this.Controls.Add(this.tilePayment);
            this.Controls.Add(this.tileEmployees);
            this.Controls.Add(this.tileCustomerType);
            this.Controls.Add(this.tileCustomer);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "Welcome to POS";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileJobs;
        private MetroFramework.Controls.MetroTile tileLogout;
        private MetroFramework.Controls.MetroTile tileIngredients;
        private MetroFramework.Controls.MetroTile tileFoods;
        private MetroFramework.Controls.MetroTile tilePayment;
        private MetroFramework.Controls.MetroTile tileEmployees;
        private MetroFramework.Controls.MetroTile tileCustomerType;
        private MetroFramework.Controls.MetroTile tileCustomer;
    }
}