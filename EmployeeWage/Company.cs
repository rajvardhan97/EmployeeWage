﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Company
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
        public class TotalEmployeeWage
        {
            public const int EmpAbsent = 0;
            public const int EmpFullTime = 1;
            public const int EmpPartTime = 2;
            public double DailyWage = 0;
            public double TotalWage = 0;
            Dictionary<String, Companies> Company = new Dictionary<string, Companies>();

            public void AddCompany(String CompanyName, int WageHour, int FullTime, int PartTime, int maxworkhour, int maxworkdays)
            {
                Companies companies = new Companies(CompanyName, WageHour, FullTime, PartTime, maxworkhour, maxworkdays);
                Company.Add(CompanyName, companies);
            }

            public void MonthlyWages(string CompanyName)
            {
                Random Check = new Random();
                int days = 1, WorkingHours = 0, TotalHours = 0;
                int status = Check.Next(0, 2);
                if (status == 0)
                {
                    Console.WriteLine("\n Employee is present");

                    if (!Company.ContainsKey(CompanyName))
                        throw new ArgumentNullException("Company not found");
                    Company.TryGetValue(CompanyName, value: out Companies? companies);

                    while (days <= companies.maxworkdays && TotalHours <= companies.maxworkhour)
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
                    Console.WriteLine("Comapny : " + CompanyName);
                    Console.WriteLine("Total working days: " + days +
                        " Total Working Hours: " + TotalHours + " Total Wage: " + TotalWage);
                }
                else
                {
                    Console.WriteLine("Employee is absent");
                }
            }
        }
    }
}
