using System;

namespace UC9
{
    class Program
    {

        static void Main(string[] args)
        {
            EmployeeWageBuilder Reliance = new EmployeeWageBuilder("Reliance", 8, 20, 10, 20, 100);
            EmployeeWageBuilder Dmart = new EmployeeWageBuilder("Dmart", 8, 25, 15, 25, 90);
            Reliance.ComputeWage();
            Console.WriteLine(Reliance.ToString());
            Dmart.ComputeWage();
            Console.WriteLine(Dmart.ToString());

        }
    }

    public class EmployeeWageBuilder {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 0;
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        string company;
        int totalHours = 0;
        int totalDays = 0;
        int empWage = 0;
        int monthWage = 0;
        int dailyHours;
        int maxWorkingDays;
        int maxWorkingHours;


        public EmployeeWageBuilder(string company, int totalHours, int totalDays, int empWage, int maxWorkingDays, int maxWorkingHours) {
            this.company = company;
            this.totalHours = totalHours;
            this.totalDays = totalDays;
            this.empWage = empWage;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        public void ComputeWage()
        {
            
            
            while (totalDays < maxWorkingDays && totalHours < maxWorkingHours)
            {
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        dailyHours = 4;
                        totalDays++;
                        break;

                    case IS_FULL_TIME:
                        dailyHours = 8;
                        totalDays++;
                        break;

                    default: dailyHours = 0; break;
                }
                empWage = dailyHours * empWage;
                monthWage += empWage;
                totalHours += dailyHours;
            }
            Console.WriteLine("Total wage : {0}", +monthWage);
            Console.ReadKey();

            public string ToString() {
                return "Total wage of the company " + this.company + " is " + this.monthWage;
            }
        }
    }
    }
    }

