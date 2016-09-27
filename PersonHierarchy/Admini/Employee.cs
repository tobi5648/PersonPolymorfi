using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy.Admini
{
    /// <summary>
    /// The Employee Class
    /// </summary>
    class Employee : Person
    {
        //  The fields
        #region Fields

        /// <summary>
        /// the base salary of the employee
        /// </summary>
        protected decimal baseSalary;

        /// <summary>
        /// The christmas bonus for the employee
        /// </summary>
        private decimal christmasBonus;

        #endregion

        //  The properties of the fields
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

        //  Here's the methods
        #region Methods
        
        /// <summary>
        /// This calculates the yearly salary plus the yearly christmasbonus
        /// </summary>
        /// <returns></returns>
        public decimal GetYearlySalary()
        {
            return (baseSalary * 12) + christmasBonus;
        }

        #endregion

        //  Here's the constructors
        #region Constructors

        /// <summary>
        /// This is the constructor for the class Employee
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="firstname"></param>
        /// <param name="lastnames"></param>
        /// <param name="ssn"></param>
        public Employee(string password, string username, string firstname, string lastnames, string ssn) : base(password, username, firstname, lastnames, ssn)
        {
            BaseSalary = baseSalary;
            ChristmasBonus = christmasBonus;
        }

        #endregion
    }
}
