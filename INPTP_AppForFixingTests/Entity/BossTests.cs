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
            boss.InsertEmpl(new Employee());

            Assert.AreEqual(12000, boss.CalcYearlySalaryCZK());
        }

        [Test()]
        public void BossWithOneSubEmplSalaryBonusTest()
        {
            Boss boss = new Boss(new Department())
            {
                MonthlySalaryCZK = 1000
            };
            boss.PerEmplSalaryBonus = 100;
            boss.InsertEmpl(new Employee());

            Assert.AreEqual(12000 + 1200, boss.CalcYearlySalaryCZK());
        }

        [Test()]
        public void BossWithTwoSubEmplYearlyIncomeBonusTest()
        {
            Boss boss = new Boss(new Department())
            {
                MonthlySalaryCZK = 1000
            };
            boss.PerEmplSalaryBonus = 100;
            boss.InsertEmpl(new Employee());
            boss.InsertEmpl(new Employee());

            Assert.AreEqual((12000 * (1 - Boss.TaxRate)) + (2 * 1200 * (1 - Boss.TaxRate)),
                boss.CalcYearlyIncome());
        }

        [Test()]
        public void BossCanHaveSubemployeesTest()
        {
            Employee empl;
            Boss boss = new Boss(new Department());
            boss.InsertEmpl(empl = new Employee());

            Assert.IsTrue(boss.HasEmployee(empl));
        }

        [Test()]
        public void BossIsAbleToCountSubemployeesTest()
        {
            Boss boss = new Boss(new Department());
            boss.InsertEmpl(new Employee());
            boss.InsertEmpl(new Employee());
            boss.InsertEmpl(new Employee());

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

            boss.InsertEmpl(empl);
            Assert.AreEqual(1, boss.EmployeeCount);
            Assert.IsTrue(boss.HasEmployee(empl));

            boss.PurgeEmpl(empl);
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

            boss.InsertEmpl(empl1);
            boss.InsertEmpl(empl2);
            boss.InsertEmpl(empl3);

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

            boss.InsertEmpl(empl1);
            boss.InsertEmpl(empl2);
            boss.InsertEmpl(empl3);

            boss.PurgeEmpl(empl2);

            employees.Add(empl1);
            employees.Add(empl3);

            Assert.AreEqual(employees, boss.GetEmployees());
        }

        [Test]
        public void BossConstructorTestCatchArgumentNullException()
        {
            Assert.That(() => new Boss(null), Throws.ArgumentNullException);
        }

        [Test]
        public void EmployeeInsertToBossControlTestCatchArgumentNullException()
        {
            Boss boss = new Boss(new Department());
            Assert.That(() => boss.InsertEmpl(null), Throws.ArgumentNullException);
        }

        [Test]
        public void EmployeePurgeToBossControlTestCatchArgumentNullException()
        {
            Boss boss = new Boss(new Department());
            Assert.That(() => boss.PurgeEmpl(null), Throws.ArgumentNullException);
        }

        [Test]
        public void BossControlHasEmployeeTestCatchArgumentNullException()
        {
            Boss boss = new Boss(new Department());
            Assert.That(() => boss.HasEmployee(null), Throws.ArgumentNullException);
        }
    }
}