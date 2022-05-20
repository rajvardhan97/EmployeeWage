using System;

namespace EmployeeWage
{
    public class Program
    {
        




        public static void Main(String[] args)
        {
            Console.WriteLine("Press 1 to check employee status\n Press 2 to find daily wage \n press 3 to check if employee is part time and wage" +
                "\n Press 4 to find monthy wage");
            Company company = new Company();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    company.CheckEmployee();
                    break;
                case 2:
                    company.DailyWage();
                    break;
                case 3:
                    company.PartTime();
                    break;
                case 4:
                    company.Monthly();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

    }
    
}
