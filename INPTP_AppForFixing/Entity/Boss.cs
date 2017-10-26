using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Boss : EmployeeClass
    {
        private HashSet<EmployeeClass> employees;
        private Department department;
        private double perEmplSalaryBonus;

        public Boss(Department department)
        {
            employees = new HashSet<EmployeeClass>();
            this.department = department;
        }

        public void SetSalaryBonus(double salaryBonus)
        {
            perEmplSalaryBonus = salaryBonus;
        }

        public void InsertEmpl(EmployeeClass empl)
        {
            employees.Add(empl);
        }

        public void PurgeEmpl(EmployeeClass empl)
        {
            employees.Remove(empl);
        }

        public bool HasEmployee(EmployeeClass empl)
        {
            return employees.Contains(empl);
        }

        public ISet<EmployeeClass> GetEmployees()
        {
            return new HashSet<EmployeeClass>(employees);
        }

        public int EmployeeCount
        {
            get { return employees.Count; }
        }

        // calculate base year salary + subemployee bonus
        public override int YearlySalary()
        {
            return (int)(base.YearlySalary() + (EmployeeCount*perEmplSalaryBonus*12));
        }

        public override double CYI()
        {
            return base.CYI() + (EmployeeCount*perEmplSalaryBonus * (1-taxrate));
        }
    }
}
