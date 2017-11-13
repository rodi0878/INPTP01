﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Employee
    {
        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                Age = CalculateAge();
            }
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public double MonthlySalaryCZK { get; set; }

        public static double TaxRate => 0.21;

        public int Age { get; private set; }

        public Employee(int id, string firstName, string lastName, string jobTitle, DateTime birthDate, double monthlySalaryCZK)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            BirthDate = birthDate;
            MonthlySalaryCZK = monthlySalaryCZK;
        }

        public virtual int getNextEmployeeId()
        {
            return id + 1;
        }

        private int CalculateAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age))
            {
                return --age;
            }
            else
            {
                return age;
            }
        }

        /// <summary>
        /// Method to count sum of 12 salaries (one per month) of the employee
        /// based on attribute monthlySalaryCZK
        /// </summary>
        /// <returns>Sum of all the 12 salaries</returns>
        public virtual double CalcYearlySalaryCZK()
        {
            return MonthlySalaryCZK * 12;
        }

        /// <summary>
        /// Method to count the net income of the employee
        /// based on attribute taxRate
        /// calls method CalcYearlySalaryCZK
        /// </summary>
        /// <returns>Net income of the employee</returns>
        public virtual double CalcYearlyIncome()
        {
            return ApplyTaxRateToSalary(CalcYearlySalaryCZK());
        }

        private double ApplyTaxRateToSalary(double salary)
        {
            return salary * (1 - TaxRate);
        }

        public override string ToString() => $"ID:  {Id}; NAME: {FirstName} {LastName}; JOB:{JobTitle}; SALARY: {MonthlySalaryCZK}";

    }
}
