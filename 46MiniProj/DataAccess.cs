using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _46MiniProj
{
    public class DataAccess<T> where T : new()
    {
        public event EventHandler<T> AbuseCheck;
        public void SaveToCSV( List<T> items, string filePath) // where T : new()
        {
            List<string> rows = new List<string>();
            T entry = new T(); //instantiation
            var cols = entry.GetType().GetProperties(); // gives type of object then its properties

            string row = "";
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);
            rows.Add(row);

            foreach (var item in items)
            {
                row = "";
                bool badWordDetector = false;
                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString(); //converting object into string 
                    badWordDetector = BadWordDetector(val);

                    if (badWordDetector == true)
                    {
                        AbuseCheck?.Invoke(this, item);
                        break;   
                    }
                    row += $",{ val}";
                }

                if (badWordDetector == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
                
            }

            File.WriteAllLines(filePath, rows);
        }

        public static bool BadWordDetector(string testString)
        {
            bool output = false;
            if (testString.ToLower().Contains("fuck") || testString.ToLower().Contains("ass"))
            {
                output = true;
            }
            return output;
        }

        //cant combine abuseCheck for car and person coz they have different dataTypes.
        public void Person_AbuseCheck(object? sender, PersonModel e)
        {
            Console.WriteLine($"Bad Word Has Been Found in {e.FirstName} {e.LastName} {e.Email}");
        }
        public void Car_AbuseCheck(object? sender, CarModel e)
        {
            Console.WriteLine($"Bad Word Has Been Found in {e.Company} {e.Model}");
        }

    }


    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class CarModel
    {
        public string Company { get; set; }
        public string Model { get; set; }
    }


}
