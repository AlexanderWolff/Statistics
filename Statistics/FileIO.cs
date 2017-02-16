using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Statistics
{
    class FileIO
    {


        /// <summary>
        /// Returns array of doubles contained within the CSV file at the specified path
        /// </summary>
        public static double[] ReadCSV(string path)
        {
            List<double> data = new List<double>();

            //Initiate File Stream
            using (var filestream = File.OpenRead(path))
            using (var reader = new StreamReader(filestream))
            {
                //While end of document is not yet reached
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var values = line.Split(',');

                    foreach(var value in values)
                    {
                        double number = Convert.ToDouble(value.ToString());
                        data.Add(number);
                    }
                }
            }
            return data.ToArray(); 
        }
    }
}
