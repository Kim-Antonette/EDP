using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInvertorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // You can add any code here if you need to load data when the form starts.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This event seems to be unused, you can delete this method or leave it empty if not needed.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Email and password cannot be empty!";
                lblError.Visible = true;  // Show the error label
            }
            else if (email == "admin@store.com" && password == "admin123")
            {
                lblError.Visible = false;  // Hide the error label
                MessageBox.Show("Login successful!");

                // Hide the login form
                this.Hide();

                // Show the Dashboard form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                lblError.Text = "Invalid email or password.";
                lblError.Visible = true;  // Show the error label
            }
        }

    }
}
