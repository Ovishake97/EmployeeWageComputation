using System;

namespace UC10
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
            employeeWageBuilder.addWage("Reliance", 8, 10, 20, 20, 100);
            employeeWageBuilder.addWage("Dmart", 10, 10, 25, 25, 90);
            employeeWageBuilder.ComputeWage();
        }
    }
    public class CompanyWage {
        public string company;
        public int totalHours = 0;
        public int totalDays = 0;
        public int empWage = 0;
        public int monthWage = 0;
        public int dailyHours;
        public int maxWorkingDays;
        public int maxWorkingHours;

        public CompanyWage(string company, int totalHours, int totalDays, int empWage, int maxWorkingDays, int maxWorkingHours)
        {
            this.company = company;
            this.totalHours = totalHours;
            this.totalDays = totalDays;
            this.empWage = empWage;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void SetMonthWage() {
            this.monthWage = monthWage;
        }
        public string ToString()
        {
            return "Total wage of the company " + this.company + " is " + this.monthWage;
        }
    }

    public class EmployeeWageBuilder
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 0;
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        int numOfCompany = 0;
        public CompanyWage[] companyWageArray;

        public EmployeeWageBuilder() {
            this.companyWageArray = new CompanyWage[5];
        }
        public void addWage(String Company, int totalHours, int totalDays, int empWage, int maxWorkingDays, int maxWorkingHours) {
            companyWageArray[this.numOfCompany] = new CompanyWage(Company, totalHours, totalDays, empWage, maxWorkingDays, maxWorkingHours);
            numOfCompany++;
        }
        //Storing company data in an array
        public void ComputeWage() {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyWageArray[i].SetMonthWage(this.ComputeWage(this.companyWageArray[i]));
                Console.WriteLine(this.companyWageArray[i].ToString());
            }
        }

        //Calculating total wage
        public int ComputeWage(CompanyWage companyWage)
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
            return monthWage;

            
        }
    }
    }

