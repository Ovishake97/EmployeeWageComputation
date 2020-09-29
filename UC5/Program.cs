using System;

namespace UC5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int empCheck = r.Next(0, 2);
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 0;
            const int dWage = 20;
            const int WORKING_DAYS = 20;
            int empWage=0;
            int monthWage=0;
            int dHours;
            for (int day = 0; day >= WORKING_DAYS; day++)
            {
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        dHours = 4; break;

                    case IS_FULL_TIME:
                        dHours = 8; break;

                    default: dHours = 0; break;
                }
                empWage = dHours * dWage;
                monthWage = monthWage + empWage;
            }
            Console.WriteLine("Total Monthly Wage is {0}",+monthWage);
            Console.ReadKey();
        }
    }
}
