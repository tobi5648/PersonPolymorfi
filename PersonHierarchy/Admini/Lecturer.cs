using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    /// <summary>
    /// The lecturer class
    /// </summary>
    class Lecturer
    {
        #region Fields

        /// <summary>
        /// The salary for a course
        /// </summary>
        private decimal courseSalary;

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

        #endregion
    }
}
