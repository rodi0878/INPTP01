using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing.Algorithm
{
    public enum SalaryUpdaterType
    {
        AllEmployees,
        OnlyForBosses
    }

    public class EmployeeSalaryUpdater
    {
        public double SalaryRatio { get; set; }
        private SalaryUpdaterType type;

        private EmployeeSalaryUpdater(SalaryUpdaterType type)
        {
            this.type = type;
        }

        public static EmployeeSalaryUpdater ConstructSalaryUpdater(SalaryUpdaterType type)
        {
            return new EmployeeSalaryUpdater(type);
        }

        public void UpdateSalaries(EmployeeClass employee)
        {
            DelegateEmployeeTraveller employeeTraveller = new DelegateEmployeeTraveller();
            employeeTraveller.VisitCallback = UpdateSalary;

            switch (type)
            {
                case SalaryUpdaterType.OnlyForBosses:
                    employeeTraveller.FilterCallback = BossFilterFunction;
                    break;
            }

            employeeTraveller.Travel(employee);
        }

        private void UpdateSalary(EmployeeClass employee)
        {
            employee.salary *= SalaryRatio;
        }

        private bool BossFilterFunction(EmployeeClass employee)
        {
            return employee is Boss;
        }
    }
}
