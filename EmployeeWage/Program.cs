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
        public static void Main(String[] args)
        {
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
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

    }
    
}
