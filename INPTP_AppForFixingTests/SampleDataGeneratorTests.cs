using INPTP_AppForFixing;
using NUnit.Framework;
using System;

namespace INPTP_AppForFixingTests
{
    [TestFixture()]
    public class SampleDataGeneratorTests
    {
        private static class asserts
        {
            public static void AssertFirstName(string firstName)
            {
                Assert.That(string.IsNullOrEmpty(firstName), Is.False, "First name must not be null or empty");
            }

            public static void AssertLastName(string lastName)
            {
                Assert.That(string.IsNullOrEmpty(lastName), Is.False, "Last name must not be null or empty");
            }

            public static void AssertJob(string job)
            {
                Assert.That(string.IsNullOrEmpty(job), Is.False, "Job must not be null or empty");
            }

            public static void AssertBirthDate(DateTime birthDate)
            {
                Assert.That(birthDate, Is.LessThanOrEqualTo(DateTime.Now), "Employee must not be born in the future");
                Assert.That(birthDate, Is.LessThanOrEqualTo(DateTime.Now.Subtract(new TimeSpan((int)(365.2425 * 18), 0, 0, 0))), "Employee must be at least 18");
                Assert.That(birthDate, Is.GreaterThanOrEqualTo(DateTime.Now.Subtract(new TimeSpan((int)(365.2425 * 60), 0, 0, 0))), "Employee must be at most 60");
            }

            public static void AssertSalary(double salary)
            {
                Assert.That(salary, Is.GreaterThanOrEqualTo(0), "Employee must not be charged for working");
                Assert.That(salary, Is.GreaterThanOrEqualTo(11000), "Salary has to be greator or equal to the minimum wage");
                Assert.That(salary, Is.LessThanOrEqualTo(3000000), "Salary should not be exceptionally high");
                Assert.That(salary % 100, Is.EqualTo(0), "Salary should be round number (hundreds)");
            }

            public static void AssertDepartmentName(string departmentName)
            {
                Assert.That(string.IsNullOrEmpty(departmentName), Is.False, "Department must not be null or empty");
            }
        }

        [Test()]
        [Repeat(100)]
        public void FirstNameShouldBeNonEmptyString()
        {
            string firstName = SampleDataGenerator.FirstName;

            asserts.AssertFirstName(firstName);
        }

        [Test()]
        [Repeat(100)]
        public void LastNameShouldBeNonEmptyString()
        {
            string lastName = SampleDataGenerator.LastName;

            asserts.AssertLastName(lastName);
        }

        [Test()]
        [Repeat(100)]
        public void JobShouldBeNonEmptyString()
        {
            string job = SampleDataGenerator.Job;

            asserts.AssertJob(job);
        }

        [Test()]
        [Repeat(100)]
        public void EmployeeShouldBeReasonablyOld()
        {
            DateTime birthDate = SampleDataGenerator.BirthDate;

            asserts.AssertBirthDate(birthDate);
        }

        [Test()]
        [Repeat(100)]
        public void EmployeeShouldHaveReasonableSalary()
        {
            double salary = SampleDataGenerator.Salary;

            asserts.AssertSalary(salary);
        }

        [Test()]
        [Repeat(100)]
        public void DepartmentNameShouldBeNonEmptyString()
        {
            string departmentName = SampleDataGenerator.DepartmentName;

            asserts.AssertDepartmentName(departmentName);
        }



        [Test()]
        public void RandomEmployee()
        {
            Employee employee = SampleDataGenerator.RandomEmployee;

            asserts.AssertFirstName(employee.FirstName);
            asserts.AssertLastName(employee.LastName);
            asserts.AssertJob(employee.JobTitle);
            asserts.AssertBirthDate(employee.BirthDate);
            asserts.AssertSalary(employee.MonthlySalaryCZK);
        }

        [Test()]
        public void RandomBoss()
        {
            Boss boss = SampleDataGenerator.RandomBoss;

            asserts.AssertFirstName(boss.FirstName);
            asserts.AssertLastName(boss.LastName);
            asserts.AssertJob(boss.JobTitle);
            asserts.AssertBirthDate(boss.BirthDate);
            asserts.AssertSalary(boss.MonthlySalaryCZK);
        }

        [Test()]
        public void RandomDepartment()
        {
            Department department = SampleDataGenerator.RandomDepartment;

            asserts.AssertDepartmentName(department.Name);
        }
    }
}
