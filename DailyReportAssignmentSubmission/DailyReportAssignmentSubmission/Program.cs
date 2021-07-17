using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College \nStudent Daily Report");
            Console.WriteLine("What course are you in? ");
            String coursename = Console.ReadLine();
            Console.WriteLine("What page number?");
            String pagenum = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            String help = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            String experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            String hours = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
