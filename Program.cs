﻿using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int present = 1;

            Random random = new Random();
            int employeeCheck = random.Next(0, 2);

            Console.WriteLine("random value" + employeeCheck);
            if (employeeCheck == present)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }
            Console.ReadLine();
        }
    }
}
