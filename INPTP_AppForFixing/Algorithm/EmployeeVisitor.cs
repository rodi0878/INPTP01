using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing.Algorithm
{
    public class DelegateEmployeeTraveller
    {
        public Action<EmployeeClass> VisitCallback { get; set; }
        public Func<EmployeeClass, bool> FilterCallback { get; set; }

        private bool FilterIsSet()
        {
            return FilterCallback != null;
        }

        public void Travel(EmployeeClass employee)
        {
            if (!FilterIsSet() || FilterCallback(employee))
                VisitCallback(employee);

            TryRecursiveTravel(employee);
        }

        private void TryRecursiveTravel(EmployeeClass employee)
        {
            if (employee is Boss boss)
            {
                foreach (EmployeeClass subemployee in boss.GetEmployees())
                {
                    Travel(subemployee);
                }
            }
        }
    }
}
