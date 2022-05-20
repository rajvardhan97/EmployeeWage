using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Companies
    {
        public int FullTime = 8;
        public int PartTime = 4;
        public int WageHour = 20;
        public int maxworkhour = 100;
        public int maxworkdays = 20;
        public String CompanyName;

        public Companies(String CompanyName, int WageHour, int FullTime, int PartTime, int maxworkhour, int maxworkdays)
        {
            this.CompanyName = CompanyName;
            this.WageHour = WageHour;
            this.FullTime = FullTime;
            this.PartTime = PartTime;
            this.maxworkhour = maxworkhour;
            this.maxworkdays = maxworkdays;
        }
    }
    class TotalEmployeeWage
    {
        public const int EmpAbsent = 0;
        public const int EmpFullTime = 1;
        public const int EmpPartTime = 2;
        public double DailyWage = 0;
        public double TotalWage = 0;
        Dictionary<String, Companies> Company = new Dictionary<string, Companies>();
        public string[] Name;
        public int IndexValue = 0;

        public TotalEmployeeWage(int number)
        {
            Company = new Dictionary<string, Companies>();
            Name = new string[2 * number];
        }

        public void AddCompany(String CompanyName, int WageHour, int FullTime, int PartTime, int maxworkhour, int maxworkdays)
        {
            Companies companies = new Companies(CompanyName, WageHour, FullTime, PartTime, maxworkhour, maxworkdays);
            Company.Add(CompanyName, companies);
            Name[IndexValue] = CompanyName;
            IndexValue++;

        }


        public void MonthlyWages(string CompanyName)
        {
            Random Check = new Random();
            int days = 1, WorkingHours = 0, TotalHours = 0, Present = 1;
            int status = Check.Next(0, 2);
            if (status == Present)
            {

                if (!Company.ContainsKey(CompanyName))
                    throw new ArgumentNullException("Company not found");
                Company.TryGetValue(CompanyName, value: out Companies? companies);

                while (days < companies.maxworkdays && TotalHours <= companies.maxworkhour)
                {

                    int CheckTime = Check.Next(0, 3);
                    switch (CheckTime)
                    {
                        case EmpAbsent:
                            WorkingHours = 0;
                            break;
                        case EmpFullTime:
                            WorkingHours = companies.FullTime;
                            break;
                        case EmpPartTime:
                            WorkingHours = companies.PartTime;
                            break;
                    }
                    DailyWage = WorkingHours * companies.WageHour;
                    TotalWage += DailyWage;
                    days++;
                    TotalHours += WorkingHours;
                }
            }
            Name[IndexValue] = Convert.ToString(TotalWage);
            IndexValue++;

        }

        public void ViewWage()
        {
            for (int i = 0; i < Name.Length; i += 2)
            {
                Console.WriteLine("Monthly Wage for {0} is {1} ", Name[i], Name[i + 1]);
            }
        }
    }
}
