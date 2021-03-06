﻿namespace PersonHierarchy.Tests
{
    #region Using

    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    #endregion

    #region TestClass

    /// <summary>
    /// Tests for the class Course
    /// </summary>
    [TestClass]
    public class CourseTests
    {
        #region Constructors

        /// <summary>
        /// Tests the constructor
        /// </summary>
        [TestMethod]
        public void ConstructorCourse()
        {
            //  Arrange
            DateTime expectedEndDate = new DateTime(2016, 9, 20);
            DateTime expectedStartDate = new DateTime(2016, 9, 25);
            string extectedTitle = "S3";
            List<IAdmissable> expectedAttendents = new List<IAdmissable>();

            //  Act


            Course course = new Course(expectedEndDate, expectedStartDate, extectedTitle, expectedAttendents);

            //  Assert
        }

        #endregion
    }

    #endregion
}
