using INPTP_AppForFixing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixingTests
{
    [TestFixture()]
    class ExportUtilsTests
    {
        private const string TEST_FILE = "exportUtilsTest.json";
        private DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Boss));

        [Test()]
        public void BossExportedCorrectlyTest()
        {
            Boss exportedBoss = createTestBoss();
            ExportUtils.Instance.SerializeBossToFile(exportedBoss, TEST_FILE);

            Boss deserializedBoss = deserializeBossFromTestFileAndDeleteIt();

            Assert.AreEqual(exportedBoss.ToString(), deserializedBoss.ToString());
        }

        [Test()]
        public void AllEmployeesExportedTest()
        {
            Boss exportedBoss = createTestBoss();
            Employee exportedEmployee = createTestEmployee();
            exportedBoss.InsertEmpl(exportedEmployee);
            ExportUtils.Instance.SerializeBossToFile(exportedBoss, TEST_FILE);

            Boss deserializedBoss = deserializeBossFromTestFileAndDeleteIt();

            Assert.AreEqual(1, deserializedBoss.EmployeeCount);
        }

        [Test()]
        public void EmployeeExportedCorrectlyTest()
        {
            Boss exportedBoss = createTestBoss();
            Employee exportedEmployee = createTestEmployee();
            exportedBoss.InsertEmpl(exportedEmployee);
            ExportUtils.Instance.SerializeBossToFile(exportedBoss, TEST_FILE);

            Boss deserializedBoss = deserializeBossFromTestFileAndDeleteIt();
            Employee deserializedEmployee = deserializedBoss.GetEmployees().First();

            Assert.AreEqual(exportedEmployee.ToString(), deserializedBoss.ToString());
        }

        private Boss deserializeBossFromTestFileAndDeleteIt()
        {
            FileStream source = File.OpenRead(TEST_FILE);
            Boss deserializedBoss = (Boss)jsonSerializer.ReadObject(source);
            source.Close();

            File.Delete(TEST_FILE);

            return deserializedBoss;
        }

        private Boss createTestBoss()
        {
            Department testDepartment = new Department("Testing");
            Boss testBoss = new Boss(testDepartment);
            testBoss.FirstName = "Testy";
            testBoss.LastName = "Testovic";
            testBoss.Job = "Lead tester";
            testBoss.MonthlySalaryCZK = 0;
            testBoss.OurBirthDate = DateTime.Now;

            return testBoss;
        }

        private Employee createTestEmployee()
        {
            Employee testEmployee = new Employee();
            testEmployee.FirstName = "Test";
            testEmployee.LastName = "Testonator";
            testEmployee.Job = "Test monkey";
            testEmployee.MonthlySalaryCZK = 0;
            testEmployee.OurBirthDate = DateTime.Now;

            return testEmployee;
        }
    }
}
