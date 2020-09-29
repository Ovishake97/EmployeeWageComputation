using System;

namespace UC8
{
    class Program
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 0;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetTotalWagePerMonth("Reliance", 20, 20, 100);
            p.GetTotalWagePerMonth("Emart", 25, 25, 90);
           
        }
        public int GetTotalWagePerMonth(string Company, int dWage, int WORKING_DAYS ,int WORKING_HOURS) {
            Random r = new Random();
            int empCheck = r.Next(0, 2);
           
            int tHours = 0;
            int tDays = 0;
            int empWage = 0;
            int monthWage = 0;
            int dHours;
            while (tDays < WORKING_DAYS && tHours < WORKING_HOURS)
            {
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        dHours = 4;
                        tDays++;
                        break;

                    case IS_FULL_TIME:
                        dHours = 8;
                        tDays++;
                        break;

                    default: dHours = 0; break;
                }
                empWage = dHours * dWage;
                monthWage += empWage;
                tHours += dHours;
            }
            Console.WriteLine("Total wage : {0}", +monthWage);
            Console.ReadKey();
        }
    }
}
