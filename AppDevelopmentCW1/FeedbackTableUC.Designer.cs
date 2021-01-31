
namespace AppDevelopmentCW1
{
    partial class FeedbackTableUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbCriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ratingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGetChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCriteria
            // 
            this.cmbCriteria.FormattingEnabled = true;
            this.cmbCriteria.Location = new System.Drawing.Point(218, 40);
            this.cmbCriteria.Name = "cmbCriteria";
            this.cmbCriteria.Size = new System.Drawing.Size(206, 21);
            this.cmbCriteria.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the Criteria:";
            // 
            // ratingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ratingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ratingChart.Legends.Add(legend1);
            this.ratingChart.Location = new System.Drawing.Point(38, 82);
            this.ratingChart.Name = "ratingChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ratingChart.Series.Add(series1);
            this.ratingChart.Size = new System.Drawing.Size(499, 255);
            this.ratingChart.TabIndex = 3;
            this.ratingChart.Text = "chart1";
            // 
            // btnGetChart
            // 
            this.btnGetChart.BackColor = System.Drawing.Color.Indigo;
            this.btnGetChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetChart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetChart.Location = new System.Drawing.Point(430, 37);
            this.btnGetChart.Name = "btnGetChart";
            this.btnGetChart.Size = new System.Drawing.Size(107, 29);
            this.btnGetChart.TabIndex = 4;
            this.btnGetChart.Text = "Get Chart";
            this.btnGetChart.UseVisualStyleBackColor = false;
            this.btnGetChart.Click += new System.EventHandler(this.btnGetChart_Click);
            // 
            // FeedbackTableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnGetChart);
            this.Controls.Add(this.ratingChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCriteria);
            this.Name = "FeedbackTableUC";
            this.Size = new System.Drawing.Size(637, 429);
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ratingChart;
        private System.Windows.Forms.Button btnGetChart;
    }
}
