using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome This is a Employee Wage problem");
            EmployeeClass Tcs = new EmployeeClass("TCS", 77, 30, 150);
            EmployeeClass CTS = new EmployeeClass("CTS", 57, 27, 100);
            Tcs.CompanyEmpWage();
            Console.WriteLine(Tcs.ToString());
            CTS.CompanyEmpWage();
            Console.WriteLine(CTS.ToString());
        }
    }
}