using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy.Admini
{
    /// <summary>
    /// The Course class
    /// </summary>
    class Course
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

        #endregion

        //  The constructors
        #region Constructors

        /// <summary>
        /// The constructor of the class Course
        /// </summary>
        /// <param name="endDate"></param>
        /// <param name="startDate"></param>
        /// <param name="title"></param>
        public Course(DateTime endDate, DateTime startDate, string title)
        {
            EndDate = endDate;
            StartDate = startDate;
            Title = title;
        }

        #endregion
    }
}
