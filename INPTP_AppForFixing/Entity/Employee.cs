using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Employee
    {
        public int id;
        public string firstName, lastName, job;
        public DateTime ourBirthDate;
        public double monthlySalaryCZK;       
        public static double taxRate = 0.21;

        public int GetAge()
        {
            DateTime endDate = DateTime.Now;
            TimeSpan timeSpan = endDate - ourBirthDate;
            int numberOfDays = GetNumberOFDays;
            if (timeSpan.TotalDays < numberOfDays)
                return 0;

            return (int)Math.Round((timeSpan.TotalDays / numberOfDays), MidpointRounding.ToEven);
        }

        public virtual double CalcYearlySalaryCZK()
        {
            return monthlySalaryCZK * 12;
        }
               
        public virtual double CalcYearlyIncome()
        {
            return CalcYearlySalaryCZK() * (1 - taxRate);
        }

        private int GetNumberOFDays()
        {
            if (DateTime.IsLeapYear(DateTime.Now.Year))
                return 366;

            return 365;
        }
    }
}
