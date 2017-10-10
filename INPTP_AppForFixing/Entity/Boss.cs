using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Boss : Employee
    {
        private HashSet<Employee> employees;
        private Department department;
        private double perEmplSalaryBonus;

        public Boss(Department department)
        {
            employees = new HashSet<Employee>();
            this.department = department;
        }


        /// <summary>
        /// Method which set salary bonus.
        /// </summary>
        /// <param name="salaryBonus">Value of salary bonus.</param>
        public void SetSalaryBonus(double salaryBonus)
        {
            perEmplSalaryBonus = salaryBonus;
        }


        /// <summary>
        /// Method on insert employee.
        /// </summary>
        /// <param name="empl">Employee which is add.</param>
        public void InsertEmpl(Employee empl)
        {
            employees.Add(empl);
        }

        /// <summary>
        /// Method on remove employee.
        /// </summary>
        /// <param name="empl">Employee which is remove.</param>
        public void PurgeEmpl(Employee empl)
        {
            employees.Remove(empl);
        }


        /// <summary>
        /// Method
        /// </summary>
        /// <param name="empl"></param>
        /// <returns>Return true if employee is find. Else return false.  </returns>
        public bool HasEmployee(Employee empl)
        {
            return employees.Contains(empl);
        }


        /// <summary>
        /// Method which return set of employees.
        /// </summary>
        /// <returns>Return al employees.</returns>
        public ISet<Employee> GetEmployees()
        {
            return new HashSet<Employee>(employees);
        }


        /// <summary>
        /// Method which return count of employees.
        /// </summary>
        /// <returns>Return count of employees..</returns>
        public int EmployeeCount
        {
            get { return employees.Count; }
        }

        /// <summary>
        /// Method which calculate base year salary and subemployee bonus.
        /// </summary>
        /// <returns>Return calculated value.</returns>
        public override double CalcYearlySalaryCZK()
        {
            return (base.CalcYearlySalaryCZK() + (EmployeeCount*perEmplSalaryBonus*12));
        }

        /// <summary>
        /// Method calculate yearly income of all employees.
        /// </summary>
        /// <returns>Return calculated value.</returns>
        public override double CalcYearlyIncome()
        {
            return base.CalcYearlyIncome() + (EmployeeCount*perEmplSalaryBonus * (1-TaxRate));
        }
    }
}
