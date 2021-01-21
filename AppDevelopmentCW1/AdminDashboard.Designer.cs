
namespace AppDevelopmentCW1
{
    partial class AdminDashboard
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
            this.btnCriteriaSetup = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnFeedbackTable = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashboardUC1 = new AppDevelopmentCW1.AdminDashboardUC();
            this.feedbackTableUC1 = new AppDevelopmentCW1.FeedbackTableUC();
            this.chartUC1 = new AppDevelopmentCW1.ChartUC();
            this.criteriaUC1 = new AppDevelopmentCW1.CriteriaUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnCriteriaSetup);
            this.panel1.Controls.Add(this.btnChart);
            this.panel1.Controls.Add(this.btnFeedbackTable);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.adminDashboardUC1);
            this.panel1.Controls.Add(this.feedbackTableUC1);
            this.panel1.Controls.Add(this.chartUC1);
            this.panel1.Controls.Add(this.criteriaUC1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtCriteria);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 470);
            this.panel1.TabIndex = 0;
            // 
            // btnCriteriaSetup
            // 
            this.btnCriteriaSetup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCriteriaSetup.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriteriaSetup.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCriteriaSetup.Location = new System.Drawing.Point(42, 364);
            this.btnCriteriaSetup.Name = "btnCriteriaSetup";
            this.btnCriteriaSetup.Size = new System.Drawing.Size(141, 87);
            this.btnCriteriaSetup.TabIndex = 7;
            this.btnCriteriaSetup.Text = "Criteria Setup";
            this.btnCriteriaSetup.UseVisualStyleBackColor = false;
            this.btnCriteriaSetup.Click += new System.EventHandler(this.btnCriteriaSetup_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChart.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChart.Location = new System.Drawing.Point(42, 271);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(141, 87);
            this.btnChart.TabIndex = 6;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnFeedbackTable
            // 
            this.btnFeedbackTable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFeedbackTable.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackTable.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFeedbackTable.Location = new System.Drawing.Point(42, 178);
            this.btnFeedbackTable.Name = "btnFeedbackTable";
            this.btnFeedbackTable.Size = new System.Drawing.Size(141, 87);
            this.btnFeedbackTable.TabIndex = 5;
            this.btnFeedbackTable.Text = "Feedback \r\nTable";
            this.btnFeedbackTable.UseVisualStyleBackColor = false;
            this.btnFeedbackTable.Click += new System.EventHandler(this.btnFeedbackTable_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboard.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Indigo;
            this.btnDashboard.Location = new System.Drawing.Point(42, 85);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(141, 87);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(42, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 67);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(641, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 14;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(253, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Dashboard:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(617, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(369, 127);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(242, 20);
            this.txtCriteria.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Location = new System.Drawing.Point(238, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 221);
            this.panel3.TabIndex = 12;
            // 
            // adminDashboardUC1
            // 
            this.adminDashboardUC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminDashboardUC1.Location = new System.Drawing.Point(189, 85);
            this.adminDashboardUC1.Name = "adminDashboardUC1";
            this.adminDashboardUC1.Size = new System.Drawing.Size(572, 366);
            this.adminDashboardUC1.TabIndex = 8;
            // 
            // feedbackTableUC1
            // 
            this.feedbackTableUC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.feedbackTableUC1.Location = new System.Drawing.Point(189, 85);
            this.feedbackTableUC1.Name = "feedbackTableUC1";
            this.feedbackTableUC1.Size = new System.Drawing.Size(572, 366);
            this.feedbackTableUC1.TabIndex = 9;
            // 
            // chartUC1
            // 
            this.chartUC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chartUC1.Location = new System.Drawing.Point(189, 85);
            this.chartUC1.Name = "chartUC1";
            this.chartUC1.Size = new System.Drawing.Size(572, 366);
            this.chartUC1.TabIndex = 11;
            // 
            // criteriaUC1
            // 
            this.criteriaUC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.criteriaUC1.Location = new System.Drawing.Point(189, 85);
            this.criteriaUC1.Name = "criteriaUC1";
            this.criteriaUC1.Size = new System.Drawing.Size(572, 366);
            this.criteriaUC1.TabIndex = 10;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCriteriaSetup;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnFeedbackTable;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private AdminDashboardUC adminDashboardUC1;
        private FeedbackTableUC feedbackTableUC1;
        private ChartUC chartUC1;
        private CriteriaUC criteriaUC1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Button button2;
    }
}