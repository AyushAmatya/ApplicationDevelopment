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
            addCriteria();
        }

        public void addCriteria()
        {

            //int locationX = 50;
            //int locationY = 10;

            int locationX = 12;
            int locationY = 100;
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"criteria.txt");
            while ((line = file.ReadLine()) != null)
            {
                // Remove the extra ','
                string comboName = line.Substring(0, line.Length - 1);

                ComboBox comboBox = new ComboBox();
                comboBox.Name = comboName;
                comboBox.Items.AddRange(new object[] { 1, 2, 3, 4 });
                comboBox.Location = new Point(locationX, locationY);
                //this.Controls.Add(comboBox);
                //this.splitContainer1.Panel1.Controls.Add(comboBox);



                //Label label0 = new Label();
                //label0.Text = comboName;
                //label0.Location = new Point(0, locationY);
                //this.Controls.Add(label);
                //this.splitContainer1.Panel1.Controls.Add(label0);

                Label label10 = new Label();
                label10.Text = comboName;
                label10.Location = new Point(8, 1);


                Panel panel10 = new Panel();
                panel10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                panel10.Size = new System.Drawing.Size(210, 24);
                panel10.Location = new Point(3, locationY);
                panel10.Controls.Add(label10);
                this.splitContainer1.Panel1.Controls.Add(panel10);
                locationY += 20;
                //private System.Windows.Forms.Label label1;


                //private System.Windows.Forms.Panel panel5;


            }

            file.Close();

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
