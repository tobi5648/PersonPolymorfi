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
        //  The fields
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
        protected List<Student> students;

        /// <summary>
        /// The lecturers of the class
        /// </summary>
        private List<Lecturer> lecturers;

        #endregion

        //  The properties of the fields
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
        public List<Student> Students
        {
            get
            {
                return students;
            }

            set
            {
                students.AddRange(value);
            }
        }

        /// <summary>
        /// Gets or sets the lecturers
        /// </summary>
        public List<Lecturer> Lecturers
        {
            get
            {
                return lecturers;
            }

            set
            {
                lecturers.AddRange(value);
            }
        }

        #endregion

        //  The constructors
        #region Constructors

        /// <summary>
        /// The constructor of the class Course
        /// </summary>
        /// <param name="endDate"></param>
        /// <param name="startDate"></param>
        /// <param name="title"></param>
        public Course(DateTime endDate, DateTime startDate, string title, List<Student> students, List<Lecturer> lecturers)
        {
            EndDate = endDate;
            StartDate = startDate;
            Title = title;
            Students = students;
            Lecturers = lecturers;
        }

        #endregion
    }
}
