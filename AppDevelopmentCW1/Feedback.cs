using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevelopmentCW1
{
    public class Feedback
    {
        
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Suggestion { get; set; }

        public Dictionary<String, String> criteria { get; set; }
        public DateTime FeedbackDate { get; set; }

        string _path = "feedback.txt";

        public string SaveFeedback (Feedback fData)
        {
            string str = JsonConvert.SerializeObject(fData, Formatting.None);
            Utility.WriteToTextFile(_path, str);
            return "success";
        }

        public void Sum(int a, int b)
        {
            Feedback f;
            f = new Feedback();
        }
        public List<Feedback> List()
        {
            string d = Utility.ReadFromTextFile(_path);
            if (d != null)
            {
                List<Feedback> ratings = JsonConvert.DeserializeObject<List<Feedback>>(d);
                return ratings;
            }
            return null;
        }
    }
}
