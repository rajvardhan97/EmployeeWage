using System;

namespace Employee
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Program program = new Program();
            program.CheckEmployee();
        }

        public int Present = 1;

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
    }
}
