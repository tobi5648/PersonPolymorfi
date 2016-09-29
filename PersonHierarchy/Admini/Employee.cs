namespace PersonHierarchy
{

    #region Using

    using System;

    #endregion

    #region Class

    /// <summary>
    /// The Employee Class
    /// </summary>
    public class Employee : Person
    {
        #region Fields

        /// <summary>
        /// the base salary of the employee
        /// </summary>
        protected decimal baseSalary;

        /// <summary>
        /// The christmas bonus for the employee
        /// </summary>
        protected decimal christmasBonus;

        #endregion
        
        #region Properties

        /// <summary>
        /// Gets or sets the base salary
        /// </summary>
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Can't be negative");
                baseSalary = value;
            }
        }

        /// <summary>
        /// Gets or sets the christmasbonus
        /// </summary>
        public decimal ChristmasBonus
        {
            get
            {
                return christmasBonus;
            }

            set
            {
                christmasBonus = value;
            }
        }

        #endregion
        
        #region Methods
        
        /// <summary>
        /// This calculates the yearly salary plus the yearly christmasbonus
        /// </summary>
        /// <returns></returns>
        public virtual decimal GetYearlySalary()
        {
            return (baseSalary * 12) + christmasBonus;
        }

        #endregion
        
        #region Constructors

        /// <summary>
        /// This is the constructor for the class Employee
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="firstname"></param>
        /// <param name="lastnames"></param>
        /// <param name="ssn"></param>
        public Employee(string password, string username, string firstname, string lastnames, string ssn, decimal baseSalary, decimal christmasBonus) : base(password, username, firstname, lastnames, ssn)
        {
            BaseSalary = baseSalary;
            ChristmasBonus = christmasBonus;
        }

        #endregion
    }

    #endregion

}
