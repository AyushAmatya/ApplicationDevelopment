
namespace AppDevelopmentCW1
{
    partial class FeedbackForm
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSuggestion = new System.Windows.Forms.TextBox();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(69, 50);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(108, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(183, 50);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(196, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(183, 93);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(196, 20);
            this.txtContactNumber.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(70, 93);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(107, 16);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(484, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(535, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSuggestion
            // 
            this.txtSuggestion.Location = new System.Drawing.Point(535, 93);
            this.txtSuggestion.Multiline = true;
            this.txtSuggestion.Name = "txtSuggestion";
            this.txtSuggestion.Size = new System.Drawing.Size(196, 62);
            this.txtSuggestion.TabIndex = 7;
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(450, 94);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(79, 16);
            this.lblSuggestion.TabIndex = 6;
            this.lblSuggestion.Text = "Suggestion:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(127, 137);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(50, 16);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "Rating:";
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRating.Location = new System.Drawing.Point(183, 137);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(196, 21);
            this.cmbRating.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(314, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(439, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 31);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtSuggestion);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSuggestion;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}