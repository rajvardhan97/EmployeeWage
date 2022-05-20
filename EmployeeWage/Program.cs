using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeWage.Companies;

namespace EmployeeWage
{
    public class Program
    {
        public static void Main(String[] args)
        {
            TotalEmployeeWage EmployeeWage = new TotalEmployeeWage(4);

            EmployeeWage.AddCompany("Reliance", 30, 10, 4, 100, 20);
            EmployeeWage.MonthlyWages("Reliance");
            EmployeeWage.AddCompany("Amazon", 25, 6, 4, 100, 20);
            EmployeeWage.MonthlyWages("Amazon");
            EmployeeWage.AddCompany("TCS", 20, 8, 4, 100, 20);
            EmployeeWage.MonthlyWages("TCS");
            EmployeeWage.AddCompany("Accenture", 20, 8, 4, 100, 20);
            EmployeeWage.MonthlyWages("Accenture");

        }
    }
    
}
