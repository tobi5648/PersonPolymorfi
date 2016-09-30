using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonHierarchy.Tests
{
    [TestClass]
    public class AdministrativeEmployeeTests
    {
        [TestMethod]
        public void ConstructorAdministrativeEmployee()
        {
            //  Arrange
            string expectedPassword = "123456789";
            string expectedUsername = "Tobi5648";
            string expectedFirstname = "Tobias";
            string expectedLastnames = "Bülow";
            string expectedSsn = "0101011234";
            decimal expectedBaseSalary = 10m;
            decimal expectedChristmasBonus = 10m;
            byte expectedPayLevel = 8;
            double expectedYearlyRisePercent = 0.3;

            //  Act
            AdministrativeEmployee administrativeEmployee = new AdministrativeEmployee(expectedPassword, expectedUsername, expectedFirstname, expectedLastnames, expectedSsn, expectedBaseSalary, expectedChristmasBonus, expectedPayLevel, expectedYearlyRisePercent);

            //  Assert
            Assert.AreEqual(expectedPassword, administrativeEmployee.Password);
            Assert.AreEqual(expectedUsername, administrativeEmployee.Username);
            Assert.AreEqual(expectedFirstname, administrativeEmployee.Firstname);
            Assert.AreEqual(expectedLastnames, administrativeEmployee.Lastnames);
            Assert.AreEqual(expectedSsn, administrativeEmployee.Ssn);
            Assert.AreEqual(expectedBaseSalary, administrativeEmployee.BaseSalary);
            Assert.AreEqual(expectedChristmasBonus, administrativeEmployee.ChristmasBonus);
            Assert.AreEqual(expectedPayLevel, administrativeEmployee.PayLevel);
            Assert.AreEqual(expectedYearlyRisePercent, administrativeEmployee.YearlyRisePercent);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void PayLevelAbove8()
        {
            //  Arrange
            string expectedPassword = "123456789";
            string expectedUsername = "Tobi5648";
            string expectedFirstname = "Tobias";
            string expectedLastnames = "Bülow";
            string expectedSsn = "0101011234";
            decimal expectedBaseSalary = 10m;
            decimal expectedChristmasBonus = 10m;
            byte expectedPayLevel = 10;
            double expectedYearlyRisePercent = 0.3;

            //  Act
            AdministrativeEmployee administrativeEmployee = new AdministrativeEmployee(expectedPassword, expectedUsername, expectedFirstname, expectedLastnames, expectedSsn, expectedBaseSalary, expectedChristmasBonus, expectedPayLevel, expectedYearlyRisePercent);

            //  Assert
            Assert.AreEqual(expectedPassword, administrativeEmployee.Password);
            Assert.AreEqual(expectedUsername, administrativeEmployee.Username);
            Assert.AreEqual(expectedFirstname, administrativeEmployee.Firstname);
            Assert.AreEqual(expectedLastnames, administrativeEmployee.Lastnames);
            Assert.AreEqual(expectedSsn, administrativeEmployee.Ssn);
            Assert.AreEqual(expectedBaseSalary, administrativeEmployee.BaseSalary);
            Assert.AreEqual(expectedChristmasBonus, administrativeEmployee.ChristmasBonus);
            Assert.AreEqual(expectedPayLevel, administrativeEmployee.PayLevel);
            Assert.AreEqual(expectedYearlyRisePercent, administrativeEmployee.YearlyRisePercent);
        }
    }
}
