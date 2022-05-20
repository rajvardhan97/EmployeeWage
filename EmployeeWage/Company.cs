using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Company
    {
        public int Present = 1, Emphour;
        public const int fulltime = 0, parttime = 1, absent = 2, wagehour = 20;

        public void CheckEmployee()
        {
            Random check = new Random();
            int CheckEmp = check.Next(0, 2);

            if (Present == CheckEmp)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

        public void DailyWage()
        {
            int wage, dailywage = 20, hour = 8;
            wage = dailywage * hour;
            Console.WriteLine("Daily Wage is " + wage);
        }
        public void PartTime()
        {
            int Emphour = 0, wagehour = 20;


            Random TimeCheck = new Random();
            int CheckTime = TimeCheck.Next(0, 3);
            switch (CheckTime)
            {
                case fulltime:
                    Emphour = 8;
                    Console.Write("Employee is fulltime\n");
                    break;

                case parttime:
                    Emphour = 4;
                    Console.Write("Employee is parttime\n");
                    break;

                case absent:
                    Emphour = 0;
                    Console.Write("Employee is absent\n");
                    break;
            }
            int EmpWageDaily = Emphour * wagehour;
            Console.WriteLine("Wage of Employee is " + EmpWageDaily);
        }
        public void Monthly()
        {
            int DayNum = 1, Hours = 0, TotalHrs = 0, TotalWageDay = 0, MonthlyWage;
            while (DayNum <= 20 || Hours <= 100)
            {
                Random TimeCheck = new Random();
                int CheckTime = TimeCheck.Next(0, 3);
                switch (CheckTime)
                {
                    case fulltime:
                        Emphour = 8;

                        break;

                    case parttime:
                        Emphour = 4;

                        break;

                    case absent:
                        Emphour = 0;

                        break;
                }
                TotalWageDay = wagehour * Emphour;
                Hours += TotalHrs;
                DayNum++;

            }
            MonthlyWage = Hours * TotalWageDay;
            Console.WriteLine("Total Monthly Wage is " + MonthlyWage);
        }
    }
}
