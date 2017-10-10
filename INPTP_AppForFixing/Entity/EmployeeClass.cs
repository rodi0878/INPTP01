using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class EmployeeClass
    {
        public int id;
        public string firstName,last_name,job;
        // our birth date
        public DateTime birth_date;
        // monthly salary in CZK
        public double salary;

        // current tax rate is 21 %
        public static double taxrate = 0.21;

        // this methods gets age of employee
        public int GetAge()
        {
            int x = 0;
            DateTime endDate = DateTime.Now;
            TimeSpan timeSpan = endDate - birth_date;
            if (timeSpan.TotalDays > 365)
                x = (int)Math.Round((timeSpan.TotalDays / 365), MidpointRounding.ToEven);
            return x;
        }

        public virtual int YearlySalary()
        {
            return (int)salary * 12;
        }

        // year income lowered by taxes
        public virtual double CYI()
        {
            return salary * (1 - taxrate);
        }
    }
}
