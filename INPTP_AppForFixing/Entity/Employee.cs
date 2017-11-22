using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        private int id;
        [DataMember]
        private string firstName;
        [DataMember]
        private string lastName;
<<<<<<< HEAD
        private string job;
        private DateTime ourBirthDate;
        private double monthlySalaryCZK;
=======
        [DataMember]
        private string job;
        [DataMember]
        private DateTime ourBirthDate;
        [DataMember]
        private double monthlySalaryCZK;
        
>>>>>>> upstream/master
        private static double taxRate = 0.21;
        private static int nextID = 0;

        public int Id
        {
            get => id; set
            {
                this.id = value;
                Employee.nextID = value >= Employee.nextID ? this.id + 1 : Employee.nextID;
            }
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Job { get => job; set => job = value; }
        public DateTime OurBirthDate { get => ourBirthDate; set => ourBirthDate = value; }
        public double MonthlySalaryCZK { get => monthlySalaryCZK; set => monthlySalaryCZK = value; }
        public static double TaxRate { get => taxRate; }

        public Employee() { }

        public Employee(int id, string firstName, string lastName, string job, DateTime ourBirthDate, double monthlySalaryCZK)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.job = job;
            this.ourBirthDate = ourBirthDate;
            this.monthlySalaryCZK = monthlySalaryCZK;
        }

        /// <summary>
        /// Always contains the next available ID
        /// </summary>
        public static int NextID
        {
            get
            {
                return Employee.nextID++;
            }
        }

        /// <summary>
        /// This method gets age of employee
        /// </summary>
        /// <returns>Age of employee</returns>
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - OurBirthDate.Year;

            if (OurBirthDate > today.AddYears(-age))
                return --age;

            return age;
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
            return CalcYearlySalaryCZK() * (1 - TaxRate);
        }

        public override string ToString()
        {
            return $"ID: {Id}; NAME: {FirstName} {LastName}; Job: {Job}; SALARY: {MonthlySalaryCZK}";
        }
    }
}
