using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Boss : Employee
    {
        private const int MONTHS_OF_YEAR = 12;

        private HashSet<Employee> employees;
        private Department department;
        public double PerEmplSalaryBonus { get; set; }

        public Boss(Department department)
        {
            employees = new HashSet<Employee>();
            this.department = department;
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
            return (base.CalcYearlySalaryCZK() + (EmployeeCount * PerEmplSalaryBonus * MONTHS_OF_YEAR));
        }

        public override double CalcYearlyIncome()
        {
            //return CalcYearlySalaryCZK() * (1 - taxRate);
            return MonthlySalaryCZK * MONTHS_OF_YEAR * (1 - taxRate) + (MONTHS_OF_YEAR * (EmployeeCount * PerEmplSalaryBonus * (1 - taxRate)));
        }
    }
}
