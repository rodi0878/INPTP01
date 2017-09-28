using Microsoft.VisualStudio.TestTools.UnitTesting;
using INPTP_AppForFixing.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing.Algorithm.Tests
{
    [TestClass()]
    public class EmployeeSalaryUpdaterTests
    {
        [TestMethod()]
        public void UpdateSalariesOfAllEmployees()
        {
            Boss boss = new Boss(new Department());
            EmployeeClass empl1, empl2;
            empl1 = new EmployeeClass() { salary = 10 };
            empl2 = new EmployeeClass() { salary = 100 };

            boss.InsertEmpl(empl1);
            boss.InsertEmpl(empl2);

            EmployeeSalaryUpdater esu = EmployeeSalaryUpdater.ConstructSalaryUpdater(SalaryUpdaterType.AllEmployees);
            esu.SalaryRatio = 2;
            esu.UpdateSalaries(boss);

            Assert.AreEqual(20, empl1.salary);
            Assert.AreEqual(200, empl2.salary);
        }
    }
}