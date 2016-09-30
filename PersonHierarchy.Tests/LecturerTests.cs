using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonHierarchy.Tests
{
    [TestClass]
    public class LecturerTests
    {
        [TestMethod]
        public void ConstructorLecturer()
        {
            //  Arrange
            string expectedPassword = "123456789";
            string expectedUsername = "Tobi5648";
            string expectedFirstname = "Tobias";
            string expectedLastnames = "Bülow";
            string expectedSsn = "0101011234";
            decimal expectedBaseSalary = 10m;
            decimal expectedChristmasBonus = 10m;
            decimal expectedCourseSalary = 10m;
            short expectedNumberOfYearlyCourses = 40;

            //  Act
            Lecturer lecturer = new Lecturer(expectedPassword, expectedUsername, expectedFirstname, expectedLastnames, expectedSsn, expectedBaseSalary, expectedChristmasBonus, expectedCourseSalary, expectedNumberOfYearlyCourses);

            //  Assert
            Assert.AreEqual(expectedPassword, lecturer.Password);
            Assert.AreEqual(expectedUsername, lecturer.Username);
            Assert.AreEqual(expectedFirstname, lecturer.Firstname);
            Assert.AreEqual(expectedLastnames, lecturer.Lastnames);
            Assert.AreEqual(expectedSsn, lecturer.Ssn);
            Assert.AreEqual(expectedBaseSalary, lecturer.BaseSalary);
            Assert.AreEqual(expectedChristmasBonus, lecturer.ChristmasBonus);
            Assert.AreEqual(expectedCourseSalary, lecturer.CourseSalary);
            Assert.AreEqual(expectedNumberOfYearlyCourses, lecturer.NumberOfYearlyCourses);
        }
    }
}
