using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    /// <summary>
    /// The Student class
    /// </summary>
    public class Student : Person, IAdmissable
    {
        #region Fields

        /// <summary>
        /// The amount of ECTS the student have
        /// </summary>
        protected short earnedECTS;

        /// <summary>
        /// The date the student began
        /// </summary>
        protected DateTime startDate;

        #endregion
        
        #region Properties

        /// <summary>
        /// Gets or sets the students amount of ECTS
        /// </summary>
        public short EarnedECTS
        {
            get
            {
                return earnedECTS;
            }

            set
            {
                earnedECTS = value;
            }
        }

        /// <summary>
        /// Gets or sets the day the student began
        /// </summary>
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Tell what degree you're after, and it calculates the amount of ECTS the user is missing
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        public short EctsLeftTo(string degree)
        {
            switch (degree)
            {
                case "Bachelor":
                    if (earnedECTS < 180)
                        return (short)(180 - earnedECTS);
                    else if (earnedECTS > 180)
                        throw new ArgumentOutOfRangeException("You should already have completed your bachelor");
                    break;
                case "Candidate":
                    if (earnedECTS < 300)
                        return (short)(300 - earnedECTS);
                    else if(earnedECTS > 300)
                        throw new ArgumentOutOfRangeException("You should already have completed your candidate");
                    break;
                case "Phd":
                    if (earnedECTS < 480)
                        return (short)(480 - earnedECTS);
                    else if (earnedECTS > 480)
                        throw new ArgumentOutOfRangeException("You should already have completed your phd");
                    break;
            }
            return 0;
        }

        /// <summary>
        /// Shows how long the user has studied
        /// </summary>
        /// <returns></returns>
        public TimeSpan StudyTimeSoFar()
        {
            return DateTime.Today - startDate;
        }

        public void EnrollIn(Course course)
        {
            
        }

        #endregion

        #region Constructors

        public Student(string password, string username, string firstname, string lastnames, string ssn) : base(password, username, firstname, lastnames, ssn)
        {
            EarnedECTS = earnedECTS;
            StartDate = startDate;
        }

        #endregion
    }
}
