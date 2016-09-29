namespace PersonHierarchy
{
    #region Using

    using System;

    #endregion

    #region Class

    public class Secretary : AdministrativeEmployee
    {
        #region Methods

        /// <summary>
        /// Admits a student to a course
        /// </summary>
        /// <param name="course"></param>
        /// <param name="student"></param>
        public void AdmitStudentTo(Course course, Student student)
        {
            try
            {
                course.Add(student);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Admits a lecturer to the course
        /// </summary>
        /// <param name="course"></param>
        /// <param name="lecturer"></param>
        public void AdmitLecturerTo(Course course, Lecturer lecturer)
        {
            try
            {
                course.Add(lecturer);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// The constructor for the class Secretary
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="firstname"></param>
        /// <param name="lastnames"></param>
        /// <param name="ssn"></param>
        /// <param name="baseSalary"></param>
        /// <param name="christmasBonus"></param>
        /// <param name="payLevel"></param>
        /// <param name="yearlyRisePercent"></param>
        public Secretary(string password, string username, string firstname, string lastnames, string ssn, decimal baseSalary, decimal christmasBonus, byte payLevel, double yearlyRisePercent) : base(password, username, firstname, lastnames, ssn, baseSalary, christmasBonus, payLevel, yearlyRisePercent)
        {

        }
        #endregion
    }

    #endregion
}
