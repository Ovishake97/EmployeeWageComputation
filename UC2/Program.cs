using System;

namespace UC2_Dailywage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int empCheck = r.Next(0, 2);
            int IF_PRESENT = 1;
            int dWage = 20;
            int empWage, empHours;
            if (empCheck == IF_PRESENT)
            {
                empHours = 8;
            }
            else {
                empHours = 0;

            }
            empWage = empHours * dWage;
            Console.WriteLine("Daily Wage : {0}",+empWage);
        }
    }
}
