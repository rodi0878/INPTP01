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
    public class EmployeeClassTests
    {
        [Test()]
        public void GetAgeTest()
        {
            EmployeeClass emp = new EmployeeClass()
            {
                birth_date = DateTime.Now
            };

            Assert.AreEqual(0, emp.GetAge());
        }

        /*[Test()]
        public void YearlySalaryTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void CYITest()
        {
            Assert.Fail();
        }*/
    }
}