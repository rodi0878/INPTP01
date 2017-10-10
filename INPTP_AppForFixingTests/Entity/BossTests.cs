using NUnit.Framework;
using INPTP_AppForFixing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing.Tests
{
    [TestFixture()]
    public class BossTests
    {
        [Test()]
        public void BossWithoutSubEmplSalaryBonusTest()
        {
            Boss boss = new Boss(new Department())
            {
                MonthlySalaryCZK = 1000
            };
            boss.InsertEmployee(new Employee());

            Assert.AreEqual(12000, boss.CalcYearlySalaryCZK());
        }

        [Test()]
        public void BossWithOneSubEmplSalaryBonusTest()
        {
            Boss boss = new Boss(new Department())
            {
                MonthlySalaryCZK = 1000
            };
            boss.SetSalaryBonus(100);
            boss.InsertEmployee(new Employee());

            Assert.AreEqual(12000 + 1200, boss.CalcYearlySalaryCZK());
        }


        [Test()]
        public void BossCanHaveSubemployeesTest()
        {
            Employee empl;
            Boss boss = new Boss(new Department());
            boss.InsertEmployee(empl = new Employee());

            Assert.IsTrue(boss.HasEmployee(empl));
        }

        [Test()]
        public void BossIsAbleToCountSubemployeesTest()
        {
            Boss boss = new Boss(new Department());
            boss.InsertEmployee(new Employee());
            boss.InsertEmployee(new Employee());
            boss.InsertEmployee(new Employee());

            Assert.AreEqual(3, boss.EmployeeCount);
        }

        [Test()]
        public void BossIsAbleToCountWithoutSubemployeesTest()
        {
            Boss boss = new Boss(new Department());

            Assert.AreEqual(0, boss.EmployeeCount);
        }

        [Test()]
        public void BossIsAbleToKickSubemployeeTest()
        {
            Boss boss = new Boss(new Department());
            Employee empl = new Employee();

            boss.InsertEmployee(empl);
            Assert.AreEqual(1, boss.EmployeeCount);
            Assert.IsTrue(boss.HasEmployee(empl));

            boss.PurgeEmployee(empl);
            Assert.AreEqual(0, boss.EmployeeCount);
        }

        [Test()]
        public void BossIsAbleToIgnoreForeignEmployeesTest()
        {
            Boss boss = new Boss(new Department());
            Employee empl = new Employee();

            Assert.AreEqual(0, boss.EmployeeCount);
            Assert.IsFalse(boss.HasEmployee(empl));
        }

        [Test()]
        public void BossGetsAllEmployees()
        {
            Boss boss = new Boss(new Department());
            HashSet<Employee> employees = new HashSet<Employee>();
            Employee empl1 = new Employee();
            Employee empl2 = new Employee();
            Employee empl3 = new Employee();

            boss.InsertEmployee(empl1);
            boss.InsertEmployee(empl2);
            boss.InsertEmployee(empl3);

            employees.Add(empl1);
            employees.Add(empl2);
            employees.Add(empl3);

            Assert.AreEqual(employees, boss.GetEmployees());
        }

        [Test()]
        public void BossGetsAllEmployeesAfterKickingEmployee()
        {
            Boss boss = new Boss(new Department());
            HashSet<Employee> employees = new HashSet<Employee>();
            Employee empl1 = new Employee();
            Employee empl2 = new Employee();
            Employee empl3 = new Employee();

            boss.InsertEmployee(empl1);
            boss.InsertEmployee(empl2);
            boss.InsertEmployee(empl3);

            boss.PurgeEmployee(empl2);

            employees.Add(empl1);
            employees.Add(empl3);

            Assert.AreEqual(employees, boss.GetEmployees());
        }
    }
}