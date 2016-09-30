using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonHierarchy.Tests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void ConstructorEmployee()
        {
            //  Arrange
            string expectedPassword = "123456789";
            string expectedUsername = "Tobi5648";
            string expectedFirstname = "Tobias";
            string expectedLastnames = "Bülow";
            string expectedSsn = "0101011234";
            decimal expectedBaseSalary = 10m;
            decimal expectedChristmasBonus = 10m;

            //  Act
            Employee employee = new Employee(expectedPassword, expectedUsername, expectedFirstname, expectedLastnames, expectedSsn, expectedBaseSalary, expectedChristmasBonus);

            //  Assert
            Assert.AreEqual(expectedPassword, employee.Password);
            Assert.AreEqual(expectedUsername, employee.Username);
            Assert.AreEqual(expectedFirstname, employee.Firstname);
            Assert.AreEqual(expectedLastnames, employee.Lastnames);
            Assert.AreEqual(expectedSsn, employee.Ssn);
            Assert.AreEqual(expectedBaseSalary, employee.BaseSalary);
            Assert.AreEqual(expectedChristmasBonus, employee.ChristmasBonus);
        }
    }
}
