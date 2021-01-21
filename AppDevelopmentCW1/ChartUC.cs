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
    public partial class ChartUC : UserControl
    {
        public ChartUC()
        {
            InitializeComponent();
            addData();
        }

        public void addData()
        {
            string[] row5 = new string[] { "Chocolate Cheesecake", "Dessert",
        "cream cheese", "***" };
            string[] row6 = new string[] { "Black Bean Dip", "Appetizer",
        "black beans, sour cream", "***" };
            object[] rows = new object[] { row5, row6 };
            foreach (string[] rowArray in rows)
            {
                this.dataGridView1.Rows.Add(rowArray);
            }
            
        }
    }
}
