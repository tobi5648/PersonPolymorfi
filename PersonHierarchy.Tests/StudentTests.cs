using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonHierarchy.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ConstructorStudent()
        {
            //  Arrange
            string expectedPassword = "123456789";
            string expectedUsername = "Tobi5648";
            string expectedFirstname = "Tobias";
            string expectedLastnames = "Bülow";
            string expectedSsn = "0101011234";
            short expectedEarnedECTS = 180;
            DateTime expectedStartDate = new DateTime(2016, 9, 20);

            //  Act
            Student student = new Student(expectedPassword, expectedUsername, expectedFirstname, expectedLastnames, expectedSsn, expectedEarnedECTS, expectedStartDate);

            //  Assert
            Assert.AreEqual(expectedPassword, student.Password);
            Assert.AreEqual(expectedUsername, student.Username);
            Assert.AreEqual(expectedFirstname, student.Firstname);
            Assert.AreEqual(expectedLastnames, student.Lastnames);
            Assert.AreEqual(expectedSsn, student.Ssn);
            Assert.AreEqual(expectedEarnedECTS, student.EarnedECTS);
            Assert.AreEqual(expectedStartDate, student.StartDate);
        }
    }
}
