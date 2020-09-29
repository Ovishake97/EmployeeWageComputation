using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation program in master branch");
            Random r = new Random();
            int empCheck = r.Next(0, 2);
            int IF_PRESENT = 1;
            if (empCheck == IF_PRESENT)
            {
                Console.WriteLine("Present");
            }
            else {
                Console.WriteLine("Absent");
            }
        }
    }
}
