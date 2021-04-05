
namespace foodOnTheGo
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWelcomeHeading = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtNewAcc = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtForgotPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.txtWelcomeHeading);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 108);
            this.panel1.TabIndex = 0;
            // 
            // txtWelcomeHeading
            // 
            this.txtWelcomeHeading.BackColor = System.Drawing.Color.SkyBlue;
            this.txtWelcomeHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWelcomeHeading.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWelcomeHeading.ForeColor = System.Drawing.Color.Green;
            this.txtWelcomeHeading.Location = new System.Drawing.Point(191, 30);
            this.txtWelcomeHeading.Name = "txtWelcomeHeading";
            this.txtWelcomeHeading.Size = new System.Drawing.Size(543, 54);
            this.txtWelcomeHeading.TabIndex = 1;
            this.txtWelcomeHeading.Text = "Welcome to Food On The Go!";
            this.txtWelcomeHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(442, 307);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(294, 31);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(442, 189);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(294, 31);
            this.txtUserName.TabIndex = 2;
            // 
            // txtNewAcc
            // 
            this.txtNewAcc.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewAcc.Location = new System.Drawing.Point(288, 509);
            this.txtNewAcc.Name = "txtNewAcc";
            this.txtNewAcc.Size = new System.Drawing.Size(190, 24);
            this.txtNewAcc.TabIndex = 4;
            this.txtNewAcc.Text = "Don\'t have an account?";
            this.txtNewAcc.Click += new System.EventHandler(this.txtNewAcc_Click);
            this.txtNewAcc.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(288, 415);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(288, 189);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(99, 25);
            this.lbUserName.TabIndex = 6;
            this.lbUserName.Text = "User Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(288, 313);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(87, 25);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password";
            // 
            // txtForgotPassword
            // 
            this.txtForgotPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtForgotPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForgotPassword.Location = new System.Drawing.Point(589, 509);
            this.txtForgotPassword.Name = "txtForgotPassword";
            this.txtForgotPassword.Size = new System.Drawing.Size(190, 24);
            this.txtForgotPassword.TabIndex = 8;
            this.txtForgotPassword.Text = "Forgot password?";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(593, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 577);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtForgotPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtNewAcc);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWelcomeHeading;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtNewAcc;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtForgotPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}