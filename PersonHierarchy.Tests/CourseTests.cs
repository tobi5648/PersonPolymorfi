namespace PersonHierarchy.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    /// <summary>
    /// Tests for the class Course
    /// </summary>
    [TestClass]
    public class CourseTests
    {
        /// <summary>
        /// Tests the constructor
        /// </summary>
        [TestMethod]
        public void ConstructorCourse()
        {
            //  Arrange
            DateTime expectedEndDate = new DateTime(2016, 9, 20);
            DateTime expectedStartDate = new DateTime(2016, 9, 25);
            string expectedTitle = "S3";
            List<IAdmissable> expectedAttendents = new List<IAdmissable>();
            
            //  Act
            
            Course course = new Course(expectedEndDate, expectedStartDate, expectedTitle, expectedAttendents);

            //  Assert
            Assert.AreEqual(expectedEndDate, course.EndDate);
            Assert.AreEqual(expectedStartDate, course.StartDate);
            Assert.AreEqual(expectedTitle, course.Title);
            Assert.AreEqual(expectedAttendents, course.Attendents);
        }
    }
}
