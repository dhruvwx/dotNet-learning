using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Events
{

   
    public class CollegeCourseModel
    {

        public event EventHandler<string> CallEvent;

        List<string> enrolledStudents = new List<string>();
        List<string> waitingList = new List<string>();

        public string Subject { get; set; }
        public int MaximumStuddents { get; set; }

        public CollegeCourseModel(string subect, int maxStudents)
        {
            Subject = subect;
            MaximumStuddents = maxStudents;
        }

        public string SignUpStudent(string name)
        {
            string output = "";
            if (enrolledStudents.Count < MaximumStuddents)
            {
                enrolledStudents.Add(name);
                output = $"{name} is enrolled";

                if(enrolledStudents.Count == MaximumStuddents)
                {
                    CallEvent?.Invoke(this , $"{Subject} is full");
                }
            }

            else
            {
                waitingList.Add(name);
                output = $"{name} is added to the Waiting list as number of seats are full";
            }
            return output;
        }

       
    }

    public static class ConsoleHelper
    {
        public static void Print(this string msg)
        {
            Console.WriteLine(msg);
        }

        public static void InvokeEventMethod(object sender, string e)
        {
            CollegeCourseModel model = (CollegeCourseModel)sender; //cating this type to sender type
            Console.WriteLine($"{model.Subject} , {e}");
        }

    }
}
