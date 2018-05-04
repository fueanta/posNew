namespace Forms
{
    partial class Login_Form
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
=======
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.passBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.emailBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.LoginBtn);
            this.metroPanel1.Controls.Add(this.passBox);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.emailBox);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(185, 297);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(433, 252);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(250, 170);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(120, 50);
            this.LoginBtn.Style = MetroFramework.MetroColorStyle.White;
            this.LoginBtn.TabIndex = 60;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginBtn.UseCustomBackColor = true;
            this.LoginBtn.UseSelectable = true;
            this.LoginBtn.UseStyleColors = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passBox
            // 
            // 
            // 
            // 
            this.passBox.CustomButton.Image = null;
            this.passBox.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.passBox.CustomButton.Name = "";
            this.passBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.passBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passBox.CustomButton.TabIndex = 1;
            this.passBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passBox.CustomButton.UseSelectable = true;
            this.passBox.CustomButton.Visible = false;
            this.passBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passBox.Lines = new string[0];
            this.passBox.Location = new System.Drawing.Point(172, 103);
            this.passBox.MaxLength = 32767;
            this.passBox.Name = "passBox";
<<<<<<< HEAD
            this.passBox.PasswordChar = '*';
=======
            this.passBox.PasswordChar = '\0';
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
            this.passBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.ShortcutsEnabled = true;
            this.passBox.Size = new System.Drawing.Size(198, 30);
            this.passBox.TabIndex = 43;
            this.passBox.UseSelectable = true;
            this.passBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(20, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password";
            // 
            // emailBox
            // 
            // 
            // 
            // 
            this.emailBox.CustomButton.Image = null;
            this.emailBox.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.emailBox.CustomButton.Name = "";
            this.emailBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.emailBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailBox.CustomButton.TabIndex = 1;
            this.emailBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailBox.CustomButton.UseSelectable = true;
            this.emailBox.CustomButton.Visible = false;
            this.emailBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.emailBox.Lines = new string[0];
            this.emailBox.Location = new System.Drawing.Point(172, 44);
            this.emailBox.MaxLength = 32767;
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailBox.SelectedText = "";
            this.emailBox.SelectionLength = 0;
            this.emailBox.SelectionStart = 0;
            this.emailBox.ShortcutsEnabled = true;
            this.emailBox.Size = new System.Drawing.Size(198, 30);
            this.emailBox.TabIndex = 43;
            this.emailBox.UseSelectable = true;
            this.emailBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(20, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Email";
            // 
            // pictureBox1
            // 
<<<<<<< HEAD
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
=======
            this.pictureBox1.Image = global::Forms.Properties.Resources.LoginIconAppl;
            this.pictureBox1.Location = new System.Drawing.Point(290, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Forms.Properties.Resources.close_black;
            this.pictureBox2.Location = new System.Drawing.Point(725, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 599);
<<<<<<< HEAD
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
=======
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroPanel1);
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
            this.Name = "Login_Form";
            this.Text = "Login";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox passBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox emailBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton LoginBtn;
<<<<<<< HEAD
=======
        private System.Windows.Forms.PictureBox pictureBox2;
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
    }
}