namespace PersonHierarchy
{
    #region Interface

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

    #endregion
}
