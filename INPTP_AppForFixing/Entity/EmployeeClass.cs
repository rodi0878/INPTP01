﻿using System;
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
        public DateTime BirthDate { get; set; }
        // monthly salary in CZK
        public double salary;

        // current tax rate is 21 %
        public static double taxrate = 0.21;

        // this methods gets age of employee
        public int GetAge()
        {
           TimeSpan timeSpan = DateTime.Now - BirthDate;

            if (timeSpan.TotalDays > 365)
                return (int)Math.Round(timeSpan.TotalDays / 365, MidpointRounding.ToEven);
                
           return 0; 
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
