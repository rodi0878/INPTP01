using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class EmployeeClass
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        // our birth date
        public DateTime BirthDate { get; set; }
        // monthly salary in CZK
        public double Salary { get; set; }

        // current tax rate is 21 %
        public static double TaxRate { get; set; } = 0.21;

        // this methods gets age of employee
        public int GetAge()
        {
            int x = 0;
            DateTime endDate = DateTime.Now;
            TimeSpan timeSpan = endDate - BirthDate;
            if (timeSpan.TotalDays > 365)
                x = (int)Math.Round((timeSpan.TotalDays / 365), MidpointRounding.ToEven);
            return x;
        }

        public virtual int YearlySalary()
        {
            return (int)Salary * 12;
        }

        // year income lowered by taxes
        public virtual double CYI()
        {
            return Salary * (1 - TaxRate);
        }
    }
}
