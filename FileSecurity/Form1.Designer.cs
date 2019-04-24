namespace FileSecurity
{
    partial class Form1
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.tfUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tfPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblIncorrectPassword = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // tfUsername
            // 
            this.tfUsername.Location = new System.Drawing.Point(75, 13);
            this.tfUsername.Name = "tfUsername";
            this.tfUsername.Size = new System.Drawing.Size(300, 20);
            this.tfUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // tfPassword
            // 
            this.tfPassword.Location = new System.Drawing.Point(75, 41);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.PasswordChar = '*';
            this.tfPassword.Size = new System.Drawing.Size(300, 20);
            this.tfPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(75, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLoginClicked);
            // 
            // lblIncorrectPassword
            // 
            this.lblIncorrectPassword.AutoSize = true;
            this.lblIncorrectPassword.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrectPassword.Location = new System.Drawing.Point(75, 68);
            this.lblIncorrectPassword.Name = "lblIncorrectPassword";
            this.lblIncorrectPassword.Size = new System.Drawing.Size(151, 13);
            this.lblIncorrectPassword.TabIndex = 5;
            this.lblIncorrectPassword.Text = "Incorrect Username/Password";
            this.lblIncorrectPassword.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(222, 99);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogoutClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 134);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblIncorrectPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tfPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tfUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tfUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tfPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblIncorrectPassword;
        private System.Windows.Forms.Button btnLogout;
    }
}