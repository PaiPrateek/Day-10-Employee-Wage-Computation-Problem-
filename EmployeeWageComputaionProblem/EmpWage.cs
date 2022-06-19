using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputaionProblem
{
    public class EmpWage
    {
        int FullTime = 1;
        int Absent = 0;
        int PartTime = 2;
        public int NumofCompany = 0;
        public CompanyEmpWage[] companyempwage;

        public  EmpWageBuilder()
        {
            this.companyempwage = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int WorkingHourPerMonth)
        {
            companyempwage[this.NumofCompany] = new CompanyEmpWage(Company, EmpWagePerHour, WorkingDaysPerMonth, WorkingHourPerMonth);
            NumofCompany++;
        }
        public  void ComputeEmpWage()
        {
            for (int i =0; i<NumofCompany;i++)
            {
                companyempwage[i].setTotalEmpWage(this.ComputeEmpWage(this.companyempwage[i]));
                Console.WriteLine(this.companyempwage[i].toString());
            }

        }
        public int ComputeEmpWage(CompanyEmpWage companyempwage)
        { 
            int EmpHrs = 0;
            int EmpWage = 0;
            int TotaklEmpWage = 0;
            int TotalWorkingDays = 0;
            int TotalWorkinhHours = 0;
            int FullDay = 0, AbsentDay = 0, PartDay = 0;


            Console.WriteLine("Company Name:" + Company);
            Console.WriteLine("...............................");
            Console.WriteLine("...............................");
            while (TotalWorkinhHours <= WorkingHourPerMonth && TotalWorkingDays < WorkingDaysPerMonth)
            {
                Random random = new Random();
                int Attendence = random.Next(0, 3);
                switch (Attendence)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        EmpHrs = 0;
                        AbsentDay++;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present (Full Time)");
                        EmpHrs = 8;
                        FullDay++;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Present (Part Time) ");
                        EmpHrs = 4;
                        PartDay++;
                        break;
                }
                Console.WriteLine("...............................");
                EmpWage = EmpHrs * EmpWagePerHour;
                TotalWorkinhHours += EmpHrs;
                TotalWorkingDays++;
                TotaklEmpWage += EmpWage;
                Console.WriteLine("Employee Daily Wage is : " + EmpWage);

            }
            Console.WriteLine("...............................");
            Console.WriteLine("...............................");
            Console.WriteLine("Working Day is :" + TotalWorkingDays);
            Console.WriteLine("Working Hours is :" + TotalWorkinhHours);
            Console.WriteLine("...............................");
            Console.WriteLine("...............................");
            Console.WriteLine("Full Day Presence is :" + FullDay);
            Console.WriteLine("Part Time Presnece is : " + PartDay);
            Console.WriteLine("Absent is :" + AbsentDay);
            Console.WriteLine("Total Employee Wage is :" + TotaklEmpWage);
            Console.WriteLine("...............................");
            Console.WriteLine("...............................");
            Console.WriteLine("Total Employee Wage for Company:" + Company + " " + "is : " + TotaklEmpWage);
        }
    }
}
