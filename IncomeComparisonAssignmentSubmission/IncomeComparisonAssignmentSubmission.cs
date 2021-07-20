using System;


namespace IncomeComparisonAssignmentSubmission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This is the Income Comparison");
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate: 15");
            Console.WriteLine("Hours Worked per week: 40");
            int p1num1 = 15;
            int p1num2 = 40;
            int p1total = p1num1 * p1num2;
            int p1Annual = p1total * 12;
            Console.WriteLine("Person1 Total :" + p1total);
            Console.WriteLine("with Annual Salary of:" + p1Annual);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: 20");
            Console.WriteLine("Hours Worked per week: 40");
            int p2num1 = 20;
            int p2num2 = 40;
            int p2total = p2num1 * p2num2;
            int p2Annual = p2total * 12;
            Console.WriteLine("Person2 Total :" + p2total);
            Console.WriteLine("with Annual Salary of:" + p2Annual);
            Console.WriteLine("---------------------------");
            bool result = p1Annual > p2Annual;
            Console.WriteLine("Is Person1 has a greater income than Person 2?:    " + result);
            Console.ReadLine();

        }
    }
}
