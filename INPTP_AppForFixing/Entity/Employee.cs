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
        public DateTime birthDate;
        public double monthlySalaryCZK;       
        public static double taxRate = 0.21;
        private readonly int numberOfDays = 365;

        /// <summary>
        /// This method gets age of employee
        /// </summary>
        /// <returns>Age of employee</returns>

        public int GetAge()
        {
            TimeSpan timeSpan = DateTime.Now - birthDate;
            if (timeSpan.TotalDays > numberOfDays)
                return (int)Math.Round((timeSpan.TotalDays / numberOfDays), MidpointRounding.ToEven);
            return 0;
        }

        public virtual double CalcYearlySalaryCZK()
        {
            return monthlySalaryCZK * 12;
        }
               
        public virtual double CalcYearlyIncome()
        {
            return CalcYearlySalaryCZK() * (1 - taxRate);
        }

    }
}
