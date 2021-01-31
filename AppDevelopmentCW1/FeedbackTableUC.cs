using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppDevelopmentCW1
{
    public partial class FeedbackTableUC : UserControl
    {
        public FeedbackTableUC()
        {
            InitializeComponent();
            SelectCriteria();
            BindReviewGrid();
        }
        private void BindReviewGrid()
        {
            Feedback obj = new Feedback();
            List<Feedback> listRating = obj.List();
            DataTable dt = Utility.ConvertToDynamicDataTable(listRating);
            //dataGridView2.DataSource = dt;

            
            var chartData = from x in dt.AsEnumerable()
                            group x by x.Field<String>("Food Rating:") into y
                            select new
                            {
                                Food = y.Key,
                                Count = y.Count()
                            };
            
            var lstChart = chartData.ToList();
            var d = Utility.ConvertToDataTable(lstChart);
            
            BindChart(d);


        }
        private void BindChart(DataTable lst)
        {
            Console.WriteLine(lst);
            ratingChart.DataSource = lst;
            ratingChart.Name = "Service Rating";
            ratingChart.Series["Series1"].XValueMember = "Food";
            ratingChart.Series["Series1"].YValueMembers = "Count";
        }
        public void SelectCriteria()
        {
            string line;
            if (File.Exists("criteria.txt"))
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"criteria.txt");
                while ((line = file.ReadLine()) != null)
                {
                    // Remove the extra ','
                    string comboName = line.Substring(0, line.Length - 1);
                    cmbCriteria.Items.Add(comboName);
                }
            }
        }

        private void btnGetChart_Click(object sender, EventArgs e)
        {
            string selectedCriteria = cmbCriteria.Items[cmbCriteria.SelectedIndex].ToString();
        }
    }
}
