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

            int locationY = 5;
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"criteria.txt");
            while ((line = file.ReadLine()) != null)
            {
                // Remove the extra ','
                string comboName = line.Substring(0, line.Length - 1);


                RadioButton radioButton1 = new RadioButton();

                Label label10 = new Label();
                label10.Text = comboName;
                label10.Location = new Point(8, 1);

                label10.AutoSize = true;
                label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label10.Size = new System.Drawing.Size(102, 20);
                label10.TabIndex = 15;

                Panel panel10 = new Panel();
                panel10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                panel10.Size = new System.Drawing.Size(210, 24);
                panel10.Location = new Point(10, locationY);
                panel10.Controls.Add(label10);
                this.panel1.Controls.Add(panel10);

                Button button11 = new Button();
                button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button11.Location = new Point(386, 1);
                button11.Size = new System.Drawing.Size(43, 21);
                button11.TabIndex = 15;
                button11.Text = "Clear";
                button11.UseVisualStyleBackColor = false;

                RadioButton radioButton15 = new RadioButton();
                radioButton15.AutoSize = true;
                radioButton15.Location = new System.Drawing.Point(118, 4);
                radioButton15.Name = "radioButton5";
                radioButton15.Size = new System.Drawing.Size(51, 17);
                radioButton15.TabIndex = 5;
                radioButton15.TabStop = true;
                radioButton15.Text = "Good";
                radioButton15.UseVisualStyleBackColor = true;

                RadioButton radioButton14 = new RadioButton();
                radioButton14.AutoSize = true;
                radioButton14.Location = new Point(291, 3);
                radioButton14.Name = "radioButton4";
                radioButton14.Size = new System.Drawing.Size(78, 17);
                radioButton14.TabIndex = 4;
                radioButton14.TabStop = true;
                radioButton14.Text = "Dissatisfied";
                radioButton14.UseVisualStyleBackColor = true;

                RadioButton radioButton13 = new RadioButton();
                radioButton13.AutoSize = true;
                radioButton13.Location = new Point(199, 3);
                radioButton13.Name = "radioButton3";
                radioButton13.Size = new System.Drawing.Size(65, 17);
                radioButton13.TabIndex = 3;
                radioButton13.TabStop = true;
                radioButton13.Text = "Average";
                radioButton13.UseVisualStyleBackColor = true;

                RadioButton radioButton12 = new RadioButton();
                radioButton12.AutoSize = true;
                radioButton12.Location = new Point(17, 3);
                radioButton12.Name = "radioButton2";
                radioButton12.Size = new System.Drawing.Size(68, 17);
                radioButton12.TabIndex = 2;
                radioButton12.TabStop = true;
                radioButton12.Text = "Excellent";
                radioButton12.UseVisualStyleBackColor = true;

                Panel panel11 = new Panel();
                panel11.SuspendLayout();
                panel11.Controls.Add(button11);
                panel11.Controls.Add(radioButton15);
                panel11.Controls.Add(radioButton14);
                panel11.Controls.Add(radioButton13);
                panel11.Controls.Add(radioButton12);
                //panel11.Controls.Add(this.panel3);
                panel11.Location = new Point(220, locationY);
                panel11.Size = new System.Drawing.Size(433, 24);
                panel11.TabIndex = 0;
                panel11.ResumeLayout(false);
                panel11.PerformLayout();
                this.panel1.Controls.Add(panel11);
                //private System.Windows.Forms.Label label1;

                locationY += 30;
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
