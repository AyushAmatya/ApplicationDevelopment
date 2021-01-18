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
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.CustomerName = txtCustomerName.Text;
            f.ContactNumber = txtContactNumber.Text;
            f.Email = txtEmail.Text;
            f.Suggestion = txtSuggestion.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtContactNumber.Text = "";
            txtEmail.Text = "";
            txtSuggestion.Text = "";
        }
    }
}
