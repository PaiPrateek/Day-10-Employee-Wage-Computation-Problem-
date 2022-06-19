using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputaionProblem
{
    public class CompanyEmp
    {
        public string Company;
        public int EmpWagePerHour;
        public int ToWorkingDaysPerMonth;
        public int WorkingHourPerMonth;
        public int TotaklEmpWage;

    }
    public CompanyEmpWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int WorkingHourPerMonth)
    {
        this.Company = Company;
        this.EmpWagePerHour = EmpWagePerHour;
        this.WorkingDaysPerMonth = WorkingDaysPerMonth;
        this.WorkingHourPerMonth = WorkingHourPerMonth;

    }
    public void SetTotalWmpWage(int TotaklEmpWage)
    {
        this.TotaklEmpWage = TotaklEmpWage;
    }
    public string totoString()
    {
        return "Total Employee Wage for Comapny:" + this.Company + "is:" + this.TotaklEmpWage;
    }
}
