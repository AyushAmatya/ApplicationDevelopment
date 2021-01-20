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
    public partial class CriteriaUC : UserControl
    {
        public CriteriaUC()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newCriteria = txtCriteria.Text;
                Utility.WriteToTextFile("criteria.txt", newCriteria, true, 1);

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
