using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevelopmentCW1
{
    public partial class LoginAsAdmin : Form
    {
        public LoginAsAdmin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                new AdminDashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Dont Leave Fields Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Check Credential", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
