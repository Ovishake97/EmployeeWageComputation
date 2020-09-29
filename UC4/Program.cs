﻿using System;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int empCheck = r.Next(0, 2);
           const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 0;
            int dWage = 20;
            int empWage;
            int dHours;
            switch (empCheck) {
                case IS_PART_TIME:
                    dHours = 4;break;

                case IS_FULL_TIME:
                    dHours = 8;break;

                default: dHours = 0;break;
            }
            empWage = dHours * dWage;
            Console.WriteLine("Wage per day : {0}",+empWage);
            Console.ReadKey();
        }
    }
}
