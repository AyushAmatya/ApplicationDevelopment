using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace AppDevelopmentCW1
{
    class Utility
    {
        public string DeleteCriteriaName { get; set; }
        public static void WriteToTextFile(string path, string data, bool append = true, int count = 1)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            using (StreamWriter writer = new StreamWriter(path, append: append))
            {
                if (!append)
                {
                    //remove opening bracket "[" from data passed
                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                    //remove last bracket "]" from data passed
                    data = data.Trim().Substring(0, data.Trim().Length - 1);
                }
                if (count != 0)
                {
                    data = data + ",";
                }
                writer.WriteLine(data);
            }
        }
    }
}
