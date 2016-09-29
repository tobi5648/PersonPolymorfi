namespace PersonHierarchy
{
    #region Using

    using System;

    #endregion

    #region Class

    /// <summary>
    /// The lecturer class
    /// </summary>
    public class Lecturer : Employee, IAdmissable
    {
        #region Fields

        /// <summary>
        /// The salary for a course
        /// </summary>
        protected decimal courseSalary;

        /// <summary>
        /// The number of courses over the year
        /// </summary>
        protected short numberOfYearlyCourses;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the salary of a course
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public decimal CourseSalary
        {
            get
            {
                return courseSalary;
            }

            set
            {
                if (value > 0)
                    courseSalary = value;
                else if (value < 0)
                    throw new ArgumentOutOfRangeException("Cant be negative");

            }
        }

        /// <summary>
        /// Gets or sets the number of courses over the year
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public short NumberOfYearlyCourses
        {
            get
            {
                return numberOfYearlyCourses;
            }

            set
            {
                if(value >= 0)
                    numberOfYearlyCourses = value;
                if (value < 0)
                    throw new ArgumentOutOfRangeException("You cant have a negative amount of courses");
            }
        }
        
        #endregion

        #region Methods

        /// <summary>
        /// Calculates the yearly salary plussed with the salary for the courses taken
        /// </summary>
        /// <returns></returns>
        public override decimal GetYearlySalary()
        {
            decimal newPay = 0;

            for (int i = 1; i <= numberOfYearlyCourses; i++)
            {
                newPay += courseSalary;
            }

            return newPay + base.GetYearlySalary();
        }

        /// <summary>
        /// Enrolls the lecturer to a course
        /// </summary>
        /// <param name="course"></param>
        public void EnrollIn(Course course)
        {
            course.Add(this);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// The constructor for the class Lecturer
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="firstname"></param>
        /// <param name="lastnames"></param>
        /// <param name="ssn"></param>
        /// <param name="baseSalary"></param>
        /// <param name="christmasBonus"></param>
        /// <param name="courseSalary"></param>
        /// <param name="numberOfYearlyCourses"></param>
        public Lecturer (string password, string username, string firstname, string lastnames, string ssn, decimal baseSalary, decimal christmasBonus, decimal courseSalary, short numberOfYearlyCourses) : base(password, username, firstname, lastnames, ssn, baseSalary, christmasBonus)
        {
            CourseSalary = courseSalary;
            NumberOfYearlyCourses = numberOfYearlyCourses;
        }

        #endregion
    }

    #endregion
}
