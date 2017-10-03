using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class EmployeeClass
    {
        private int id;
        private string firstName;
        private string lastName;
        private string job;

        // our birth date
        private DateTime birthDate;
        // monthly salary in CZK
        private double salary;

        public int ID
        {
            get { return id; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string Job
        {
            get { return job; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // current tax rate is 21 %
        private static double taxrate = 0.21;

        public static double Taxrate
        {
            get { return taxrate; }
        }

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
            return (int)salary * 12;
        }

        // year income lowered by taxes
        public virtual double CYI()
        {
            return salary * (1 - taxrate);
        }
    }
}
