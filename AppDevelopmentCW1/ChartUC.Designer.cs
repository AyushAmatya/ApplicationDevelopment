
namespace AppDevelopmentCW1
{
    partial class ChartUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSortByDateAsc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSortByDateDesc = new System.Windows.Forms.Button();
            this.btnSortByNameDesc = new System.Windows.Forms.Button();
            this.btnSortByNameAsc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "LIST OF ALL CUSTOMER FEEDBACKS:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 40);
            this.panel1.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(19, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 204);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSortByDateAsc
            // 
            this.btnSortByDateAsc.BackColor = System.Drawing.Color.Indigo;
            this.btnSortByDateAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByDateAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSortByDateAsc.Location = new System.Drawing.Point(193, 73);
            this.btnSortByDateAsc.Name = "btnSortByDateAsc";
            this.btnSortByDateAsc.Size = new System.Drawing.Size(115, 24);
            this.btnSortByDateAsc.TabIndex = 25;
            this.btnSortByDateAsc.Text = "Ascending";
            this.btnSortByDateAsc.UseVisualStyleBackColor = false;
            this.btnSortByDateAsc.Click += new System.EventHandler(this.btnSortByDateAsc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sort by Feedback Date:";
            // 
            // btnSortByDateDesc
            // 
            this.btnSortByDateDesc.BackColor = System.Drawing.Color.Indigo;
            this.btnSortByDateDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByDateDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSortByDateDesc.Location = new System.Drawing.Point(314, 73);
            this.btnSortByDateDesc.Name = "btnSortByDateDesc";
            this.btnSortByDateDesc.Size = new System.Drawing.Size(115, 24);
            this.btnSortByDateDesc.TabIndex = 26;
            this.btnSortByDateDesc.Text = "Descending";
            this.btnSortByDateDesc.UseVisualStyleBackColor = false;
            // 
            // btnSortByNameDesc
            // 
            this.btnSortByNameDesc.BackColor = System.Drawing.Color.Indigo;
            this.btnSortByNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByNameDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSortByNameDesc.Location = new System.Drawing.Point(314, 113);
            this.btnSortByNameDesc.Name = "btnSortByNameDesc";
            this.btnSortByNameDesc.Size = new System.Drawing.Size(115, 24);
            this.btnSortByNameDesc.TabIndex = 29;
            this.btnSortByNameDesc.Text = "Descending";
            this.btnSortByNameDesc.UseVisualStyleBackColor = false;
            // 
            // btnSortByNameAsc
            // 
            this.btnSortByNameAsc.BackColor = System.Drawing.Color.Indigo;
            this.btnSortByNameAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByNameAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSortByNameAsc.Location = new System.Drawing.Point(193, 113);
            this.btnSortByNameAsc.Name = "btnSortByNameAsc";
            this.btnSortByNameAsc.Size = new System.Drawing.Size(115, 24);
            this.btnSortByNameAsc.TabIndex = 28;
            this.btnSortByNameAsc.Text = "Ascending";
            this.btnSortByNameAsc.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sort by Customer Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(25, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 32);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(25, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(527, 32);
            this.panel5.TabIndex = 3;
            // 
            // ChartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnSortByNameDesc);
            this.Controls.Add(this.btnSortByNameAsc);
            this.Controls.Add(this.btnSortByDateDesc);
            this.Controls.Add(this.btnSortByDateAsc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "ChartUC";
            this.Size = new System.Drawing.Size(580, 385);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSortByDateAsc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSortByDateDesc;
        private System.Windows.Forms.Button btnSortByNameDesc;
        private System.Windows.Forms.Button btnSortByNameAsc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
