using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    public class Secretary : AdministrativeEmployee
    {

        #region Methods

        public void AdmitStudentTo(Course course, Student student)
        {
            course.Add(student);
        }

        public void AdmitLecturerTo(Course course, Lecturer lecturer)
        {
            course.Add(lecturer);
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
}
