using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int empCheck = r.Next(0, 2);
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 0;
            int dWage = 20;
            int empWage;
            int dHours;
            if (empCheck == IS_FULL_TIME)
            {
                dHours = 8;
                Console.WriteLine("Full time");
            }
            else if (empCheck == IS_PART_TIME)
            {
                dHours = 4;
                Console.WriteLine("Part time");
            }
            else {
                dHours = 0;
            }
            empWage = dHours * dWage;
            Console.WriteLine("Wage: {0}", +empWage);
            Console.ReadKey();

        }
    }
}
