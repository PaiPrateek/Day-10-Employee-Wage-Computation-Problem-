using System;

namespace EmployeeWageComputaionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empwagebuilder = new EmpWageBuilder();
            empwagebuilder.AddCompanyEmpWage("D-Mart", 20, 2, 10);
            empwagebuilder.AddCompanyEmpWage("Relience", 10, 4, 20);
            empwagebuilder.ComputeEmpWage();

        }
    }
}
