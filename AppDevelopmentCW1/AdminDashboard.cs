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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            addCriteria();
        }
        public void addCriteria()
        {

            //int locationX = 50;
            //int locationY = 10;

            int locationY = 10;
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"criteria.txt");
            while ((line = file.ReadLine()) != null)
            {
                // Remove the extra ','
                string comboName = line.Substring(0, line.Length - 1);

                Label label13 = new Label();
                label13.AutoSize = true;
                label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                label13.Location = new System.Drawing.Point(6, 5);
                label13.TabIndex = 1;
                label13.Size = new System.Drawing.Size(94, 16);
                label13.Text = comboName;

                Button btnDelete11 = new Button();
                btnDelete11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                btnDelete11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDelete11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btnDelete11.Location = new System.Drawing.Point(352, 3);
                btnDelete11.Size = new System.Drawing.Size(62, 21);
                btnDelete11.Text = "Delete";
                btnDelete11.UseVisualStyleBackColor = false;

                Panel panel13 = new Panel();
                panel13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                panel13.Controls.Add(btnDelete11);
                panel13.Controls.Add(label13);
                panel13.Location = new System.Drawing.Point(17, locationY);
                panel13.Size = new System.Drawing.Size(417, 27);
                panel13.TabIndex = 2;

                this.panel3.Controls.Add(panel13);



                //private System.Windows.Forms.Label label1;

                locationY += 35;
                //private System.Windows.Forms.Panel panel5;

            }

            file.Close();

        }
    

    private void btnFeedbackTable_Click(object sender, EventArgs e)
        {
            this.btnFeedbackTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFeedbackTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFeedbackTable.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackTable.ForeColor = System.Drawing.Color.Indigo;

            this.btnChart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnChart.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.btnCriteriaSetup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCriteriaSetup.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnCriteriaSetup.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriteriaSetup.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.btnDashboard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnDashboard.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.feedbackTableUC1.BringToFront();

            this.label1.Text = "Admin Feedback Table:";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboard.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Indigo;

            this.btnChart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnChart.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.btnCriteriaSetup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCriteriaSetup.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnCriteriaSetup.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriteriaSetup.ForeColor = System.Drawing.SystemColors.WindowFrame;
            
            this.btnFeedbackTable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFeedbackTable.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnFeedbackTable.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackTable.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.adminDashboardUC1.BringToFront();

            this.label1.Text = "Admin Dashboard:";
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            this.btnChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChart.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.Color.Indigo;
            
            this.btnDashboard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnDashboard.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.btnCriteriaSetup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCriteriaSetup.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnCriteriaSetup.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriteriaSetup.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.btnFeedbackTable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFeedbackTable.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnFeedbackTable.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackTable.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.chartUC1.BringToFront();

            this.label1.Text = "Admin Chart View:";
        }

        private void btnCriteriaSetup_Click(object sender, EventArgs e)
        {
            this.btnCriteriaSetup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriteriaSetup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriteriaSetup.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriteriaSetup.ForeColor = System.Drawing.Color.Indigo;

            this.btnDashboard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnDashboard.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.WindowFrame;
            
            this.btnChart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnChart.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.btnFeedbackTable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFeedbackTable.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnFeedbackTable.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackTable.ForeColor = System.Drawing.SystemColors.WindowFrame;

            this.criteriaUC1.BringToFront();
            this.panel3.BringToFront();
            this.label1.Text = "Admin Criteria Setup:";
            this.txtCriteria.BringToFront();
            this.button1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newCriteria = txtCriteria.Text;
                Utility.WriteToTextFile("criteria.txt", newCriteria, true, 1);
                addCriteria();
                txtCriteria.Text = "";
                MessageBox.Show("Criteria Added");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurres", "Data not added");
            }
        }
    }
}
