using System;

namespace UC7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
             p.GetTotalWagePerMonth();
           
        }

        public int GetTotalWagePerMonth() {
            Random r = new Random();
            int empCheck = r.Next(0, 2);
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 0;
            const int dWage = 20;
            const int WORKING_DAYS = 20;
            const int WORKING_HOURS = 100;
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
            return monthWage;
        }
    }
    }

