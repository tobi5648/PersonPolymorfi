using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    /// <summary>
    /// The Course class
    /// </summary>
    public class Course
    {
        #region Fields

        /// <summary>
        /// The date where the course ends
        /// </summary>
        protected DateTime endDate;

        /// <summary>
        /// The date where the course starts
        /// </summary>
        protected DateTime startDate;

        /// <summary>
        /// The title of the course
        /// </summary>
        protected string title;

        /// <summary>
        /// The list of students for the class
        /// </summary>
        protected List<IAdmissable> attendents;

        #endregion
        
        #region Properties

        /// <summary>
        /// Gets or sets the end date of the course
        /// </summary>
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        /// <summary>
        /// Gets or sets the date where the course starts
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

        /// <summary>
        /// Gets or sets the title of the course
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        /// <summary>
        /// Gets or sets the list of students
        /// </summary>
        public List<IAdmissable> Attendents
        {
            get
            {
                return attendents;
            }

            set
            {
                attendents = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds to the course
        /// </summary>
        /// <param name="participant"></param>
        /// <exception cref="ArgumentException"></exception>
        public void Add(IAdmissable participant)
        {
            if(!attendents.Contains(participant))
            {
                if (participant is Lecturer)
                {
                    bool hasLecturer = false;
                    foreach (IAdmissable person in attendents)
                    {
                        if (person is Lecturer)
                        {
                            hasLecturer = true;
                        }
                    }
                    if (!hasLecturer)
                    {
                        attendents.Add(participant);
                    }
                }
                else
                {

                }
            }
            else
            {
                
                throw new ArgumentException("Person already exists in the course");
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// The constructor of the class Course
        /// </summary>
        /// <param name="endDate"></param>
        /// <param name="startDate"></param>
        /// <param name="title"></param>
        public Course(DateTime endDate, DateTime startDate, string title, List<IAdmissable> attendents)
        {
            EndDate = endDate;
            StartDate = startDate;
            Title = title;
            Attendents = attendents;
        }

        #endregion
    }
}
