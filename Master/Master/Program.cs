using System;

namespace EmployeeWageV2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageCalc empWagecalc = new EmpWageCalc();
            empWagecalc.AddCompanyWage("Dmart", 20, 2, 20,100);
            empWagecalc.AddCompanyWage("Reliance", 15, 14, 40,90);
            empWagecalc.ComputeEmpWage();
            Console.WriteLine("Total wage for Dmart is: " + empWagecalc.GetTotalWage("Dmart"));
            Console.ReadKey();
        }
    }

    public interface IComputeWage
    {
        void AddCompanyWage(string company, int dWage,int totalWorkingHours, int WorkingDays, int maxHours);

        void ComputeEmpWage();
    }

    public interface IComputeWageV2
    {
        int GetTotalWage(string company);
    }
}
    
