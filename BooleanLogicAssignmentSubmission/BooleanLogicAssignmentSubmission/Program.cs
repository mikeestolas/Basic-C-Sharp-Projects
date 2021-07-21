using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean Logic Assignment Submission");
            Console.WriteLine("What is your age?");
            String AgeFromUser = Console.ReadLine();
            int age = Convert.ToInt32(AgeFromUser);
            Console.WriteLine("Have you ever had a DUI? answer: True or False?");
            String DUIFromUser = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIFromUser);
            Console.WriteLine("How many speeding tickets do you have?");
            String SpeedFromUser = Console.ReadLine();
            int Speed = Convert.ToInt32(SpeedFromUser);
            Console.WriteLine("Qualified?");
            bool result = (age >= 15 && DUI != true && Speed < 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
