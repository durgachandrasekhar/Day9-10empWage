using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeWage employee = new EmployeeWage();

            employee.AddCompanyEmpWage("TCS", 20, 22, 121);
            employee.AddCompanyEmpWage("CTS", 33, 24, 134);
            employee.ComputeEmpWage();
            Console.WriteLine("Total wage for Tcs company : " + employee.getTotalWage("CTS"));
        }
    }
}