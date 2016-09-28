using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonHierarchy;

namespace PersonHierarchy
{
    /// <summary>
    /// Interface for Admissions
    /// </summary>
    public interface IAdmissable
    {
        /// <summary>
        /// Enroll a course
        /// </summary>
        /// <param name="course"></param>
        void EnrollIn(Course course);
    }
}
