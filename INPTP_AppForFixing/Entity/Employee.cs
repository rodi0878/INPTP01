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

        /// <summary>
        /// Method to count age of the employee 
        /// based on attribute ourBirthDate
        /// </summary>
        /// <returns>Age of the employee rounded to years</returns>
        public int GetAge()
        {
            int x = 0;
            DateTime endDate = DateTime.Now;
            TimeSpan timeSpan = endDate - ourBirthDate;
            if (timeSpan.TotalDays > 365)
                x = (int)Math.Round((timeSpan.TotalDays / 365), MidpointRounding.ToEven);
            return x;
        }

        /// <summary>
        /// Method to count sum of 12 salaries (one per month) of the employee
        /// based on attribute monthlySalaryCZK
        /// </summary>
        /// <returns>Sum of all the 12 salaries</returns>
        public virtual double CalcYearlySalaryCZK()
        {
            return monthlySalaryCZK * 12;
        }
            
        /// <summary>
        /// Method to count the net income of the employee
        /// based on attribute taxRate
        /// calls method CalcYearlySalaryCZK
        /// </summary>
        /// <returns>Net income of the employee</returns>
        public virtual double CalcYearlyIncome()
        {
            return CalcYearlySalaryCZK() * (1 - taxRate);
        }
    }
}
