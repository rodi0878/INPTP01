using Microsoft.VisualStudio.TestTools.UnitTesting;
using INPTP_AppForFixing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing.Tests
{
    [TestClass()]
    public class EmployeeClassTests
    {
        [TestMethod()]
        public void NewbornEmployeeShouldHaveAgeOf0()
        {
            EmployeeClass emp = new EmployeeClass() {
                birth_date = DateTime.Now
            };

            Assert.AreEqual(0, emp.GetAge());
        }

        [TestMethod()]
        public void OneYearEmployeeShouldHaveAgeOf1()
        {
            DateTime birthDate = DateTime.Now.AddYears(-1).AddSeconds(-5);

            EmployeeClass emp = new EmployeeClass()
            {
                birth_date = birthDate
            };

            Assert.AreEqual(1, emp.GetAge());
        }

        [TestMethod()]
        public void TenYearEmployeeShouldHaveAgeOf1()
        {
            DateTime birthDate = DateTime.Now.AddYears(-10).AddSeconds(-5);

            EmployeeClass emp = new EmployeeClass()
            {
                birth_date = birthDate
            };

            Assert.AreEqual(10, emp.GetAge());
        }

        [TestMethod()]
        public void YearlySalaryTestOnIntegerValue()
        {
            EmployeeClass emp = new EmployeeClass()
            {
                salary = 1000
            };
            double yearlySalary = 1000 * 12;

            Assert.AreEqual(yearlySalary, emp.YearlySalary());
        }

        [TestMethod()]
        public void YearlySalaryTestOnDoubleValue()
        {
            EmployeeClass emp = new EmployeeClass()
            {
                salary = 123.345
            };
            double yearlySalary = 123.345 * 12;

            Assert.AreEqual(yearlySalary, emp.YearlySalary());
        }

        [TestMethod()]
        public void CleanYearIncomeShouldBeCorrect()
        {
            EmployeeClass emp = new EmployeeClass()
            {
                salary = 123.345
            };

            // TODO: fix me!
            double taxRate = 0.21;
            double cyi = 123.345 * (1 - taxRate);

            Assert.AreEqual(cyi, emp.CYI());
        }

    }
}