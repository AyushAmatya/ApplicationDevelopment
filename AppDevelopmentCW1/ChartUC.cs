using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            Feedback obj = new Feedback();
            List<Feedback> listRating = obj.List();
            DataTable dt = Utility.ConvertToDynamicDataTable(listRating);
            Console.WriteLine(listRating);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["criteria"].Visible = false;

        }

        
    }
}
