using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public DateTime OurBirthDate { get; set; }
        public double MonthlySalaryCZK { get; set; }   
        
        public const double TAX_RATE = 0.21;
        private const int MONTHS_OF_YEAR = 12;
        private const int DAYS_OF_YEAR = 365;

        public int GetAge()
        {
            int age = 0;
            DateTime endDate = DateTime.Now;
            TimeSpan timeSpan = endDate - OurBirthDate;
            if (timeSpan.TotalDays > DAYS_OF_YEAR)
                age = (int)Math.Round((timeSpan.TotalDays / DAYS_OF_YEAR), MidpointRounding.ToEven);
            return age;
        }

        public virtual double CalcYearlySalaryCZK()
        {
            return MonthlySalaryCZK * MONTHS_OF_YEAR;
        }
               
        public virtual double CalcYearlyIncome()
        {
            return CalcYearlySalaryCZK() * (1 - TAX_RATE);
        }
    }
}
