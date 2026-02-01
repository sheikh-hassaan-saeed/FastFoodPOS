namespace FastFoodPOS
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            Usernamelb = new Label();
            Passwordlb = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(230, 54);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 48);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 125);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 48);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Usernamelb
            // 
            Usernamelb.AutoSize = true;
            Usernamelb.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Usernamelb.Location = new Point(46, 54);
            Usernamelb.Name = "Usernamelb";
            Usernamelb.Size = new Size(156, 38);
            Usernamelb.TabIndex = 2;
            Usernamelb.Text = "Username:";
            // 
            // Passwordlb
            // 
            Passwordlb.AutoSize = true;
            Passwordlb.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passwordlb.Location = new Point(46, 135);
            Passwordlb.Name = "Passwordlb";
            Passwordlb.Size = new Size(147, 38);
            Passwordlb.TabIndex = 3;
            Passwordlb.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.LemonChiffon;
            btnLogin.Location = new Point(230, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(254, 49);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 271);
            Controls.Add(btnLogin);
            Controls.Add(Passwordlb);
            Controls.Add(Usernamelb);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "Tasty Restaurent Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label Usernamelb;
        private Label Passwordlb;
        private Button btnLogin;
    }
}