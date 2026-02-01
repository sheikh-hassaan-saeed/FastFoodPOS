using FastFoodPOS.Common;
using FastFoodPOS.Controller;
using FastFoodPOS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FastFoodPOS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin adminAttempt = new Admin();
            adminAttempt.Username = txtUsername.Text;
            adminAttempt.UserPassword = txtPassword.Text;

            LoginController loginControl = new LoginController();

            if (loginControl.ExecuteLogin(adminAttempt))
            {
                FastFoodPOS mainApp = new FastFoodPOS();
                mainApp.Show();
                this.Hide();
            }
            else
            {
                // THIS WILL TELL YOU IF THE LOGIN FAILED
                MessageBox.Show("Invalid Username or Password!", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
