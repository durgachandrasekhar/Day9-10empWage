using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage.EmployeeClass obj1 = new EmpWage.EmployeeClass();
            obj1.CompanyEmpWage("CTS", 57, 27, 100);
            obj1.CompanyEmpWage("TCS", 77, 30, 150);
        }
    }
}
