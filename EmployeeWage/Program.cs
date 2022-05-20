using System;

namespace Employee
{
    public class Program
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




        public static void Main(String[] args)
        {
            Console.WriteLine("Press 1 to check employee status\n Press 2 to find daily wage \n press 3 to check if employee is part time and wage" +
                "\n Press 4 to find monthy wage");
            Program program = new Program();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    program.CheckEmployee();
                    break;
                case 2:
                    program.DailyWage();
                    break;
                case 3:
                    program.PartTime();
                    break;
                case 4:
                    program.Monthly();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

    }
    
}
