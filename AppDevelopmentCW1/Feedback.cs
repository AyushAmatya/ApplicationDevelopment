using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevelopmentCW1
{
    public class Feedback
    {
        private string _customerName;
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public string Suggestion { get; set; }

        public string SaveData (Feedback f)
        {
            return "test";
        }

        public void Sum(int a, int b)
        {
            Feedback f;
            f = new Feedback();
        }
    }
}
