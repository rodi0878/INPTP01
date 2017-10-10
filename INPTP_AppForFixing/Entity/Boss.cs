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

        public void SetSalaryBonus(double salaryBonus)
        {
            perEmplSalaryBonus = salaryBonus;
        }

        public void InsertEmpl(Employee empl)
        {
            employees.Add(empl);
        }

        public void PurgeEmpl(Employee empl)
        {
            employees.Remove(empl);
        }

        public bool HasEmployee(Employee empl)
        {
            return employees.Contains(empl);
        }

        public ISet<Employee> GetEmployees()
        {
            return new HashSet<Employee>(employees);
        }

        public int EmployeeCount
        {
            get { return employees.Count; }
        }

        // calculate base year salary + subemployee bonus
        public override double CalcYearlySalaryCZK()
        {
            return (base.CalcYearlySalaryCZK() + (EmployeeCount*perEmplSalaryBonus*12));
        }

        public override double CalcYearlyIncome()
        {
            return base.CalcYearlyIncome() + (EmployeeCount*perEmplSalaryBonus * (1-taxRate));
        }
    }
}
