using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageV2
{
    public class EmpWageBuilder
    {
        public string company;
        public int dWage;
        public int totalWorkingHours;
        public int workingDays;
        public int maxHours;
        public int totalWage;


        public EmpWageBuilder(string company, int dWage, int totalWorkingHours, int workingDays, int maxHours)
        {
            this.company = company;
            this.dWage = dWage;
            this.totalWorkingHours = totalWorkingHours;
            this.workingDays = workingDays;
            this.maxHours = maxHours;
            this.totalWage = 0;
        }
        public void SetTotalWage(int totalWage) {
            this.totalWage = totalWage;
        }
        public string toString() {
            return "The total employee wage for company " + this.company + " is " + this.totalWage;
        }
    }
    //Using Interface Approach
        public class EmpWageCalc : IComputeWage{
            public const int IS_FULL_TIME = 1;
            public const int IS_PART_TIME = 2;

            private LinkedList<EmpWageBuilder> companyWageList;
            private Dictionary<string, EmpWageBuilder> companyToEmpWageMap;

            public EmpWageCalc() {
                this.companyWageList = new LinkedList<EmpWageBuilder>();
                this.companyToEmpWageMap = new Dictionary<string, EmpWageBuilder>();
            }
        //Adding different company details
            public void AddCompanyWage(string company, int dWage, int totalWorkingHours, int workingDays, int maxHours) {
                EmpWageBuilder empWageBuilder = new EmpWageBuilder(company, dWage, totalWorkingHours, workingDays, maxHours);
                this.companyWageList.AddLast(empWageBuilder);
                this.companyToEmpWageMap.Add(company, empWageBuilder);
            }

            public void ComputeEmpWage() {
                foreach (EmpWageBuilder empWageBuilder in this.companyWageList) {
                    int totalEmpWageTemp = this.ComputeEmpWage(empWageBuilder);
                    empWageBuilder.SetTotalWage(totalEmpWageTemp);
                    Console.WriteLine(empWageBuilder.toString());
                }
            }
        //Calculating monthly wages for different companies
            public int ComputeEmpWage(EmpWageBuilder empWageBuilder)
            {
                int totalEmpHours = 0;
                int days = 0;
                int empHours = 0;
                int totalWagePerDay = 0;
                int totalWagePerMonth = 0;
                while (totalEmpHours < empWageBuilder.maxHours && days < empWageBuilder.workingDays)
                {
                    EmpWageCalc empWageCalc = new EmpWageCalc();
                    empHours = empWageCalc.GetWorkingHours();

                    if (totalEmpHours == 96)
                    {
                        empHours = 4;
                    }
                    if (empHours != 0)
                    {
                        days++;
                        totalEmpHours = empHours + totalEmpHours;
                        totalWagePerDay = empHours * empWageBuilder.dWage;
                        totalWagePerMonth += totalWagePerDay;
                        Console.WriteLine("Total Wage per Day.." + totalWagePerDay);
                    }
                }
                return totalWagePerMonth;

            }
            public int GetWorkingHours()
            {
                const int FULL_TIME = 1;
                const int PART_TIME = 2;
                int empHours = 0;
                Random random = new Random();

                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        empHours = 8;
                        break;
                    case PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                return empHours;
            }

            public int GetTotalWage(string company)
            {
                return this.companyToEmpWageMap[company].totalWage;
            }


        }

    
}
