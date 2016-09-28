using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    /// <summary>
    /// The administrative employee
    /// </summary>
    class AdministrativeEmployee : Employee
    {
        //  Here's the fields
        #region Fields

        /// <summary>
        /// The employees paylevel
        /// </summary>
        protected byte payLevel;

        /// <summary>
        /// The yearly rise percentage of the employee
        /// </summary>
        protected double yearlyRisePercent;

        #endregion

        //  Here's the properties of the fields
        #region Properties

        /// <summary>
        /// Gets or sets the paylevel of the employee
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public byte PayLevel
        {
            get
            {
                return payLevel;
            }

            set
            {
                if (value <= 8)
                    payLevel = value;
                else if (value > 8)
                    throw new ArgumentOutOfRangeException("Paylevel can't get higher than 8");
            }
        }

        /// <summary>
        /// Gets or sets the yearly rise percentage of the employee
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double YearlyRisePercent
        {
            get
            {
                return yearlyRisePercent;
            }

            set
            {
                if (value > 0)
                    yearlyRisePercent = value;
                else if (value < 0)
                    throw new ArgumentOutOfRangeException("A raise can't be negative");
            }
        }

        #endregion

        //  Here's the methods
        #region Methods

        /// <summary>
        /// A method to get the yearly salary with the yearly rise
        /// </summary>
        /// <returns></returns>
        public override decimal GetYearlySalary()
        {
            decimal newPay = 0;

            for (int i = 1;  i <= payLevel; i++)
            {
                newPay += base.GetYearlySalary() * (decimal)yearlyRisePercent;
            }

            return newPay;
        }

        #endregion

        //  Here's the Constructors
        #region Constructors

        /// <summary>
        /// The constructor for the administrative employee
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="firstname"></param>
        /// <param name="lastnames"></param>
        /// <param name="ssn"></param>
        /// <param name="baseSalary"></param>
        /// <param name="christmasBonus"></param>
        /// <param name="payLevel"></param>
        /// <param name="yearlyRisePercent"></param>
        public AdministrativeEmployee(string password, string username, string firstname, string lastnames, string ssn, decimal baseSalary, decimal christmasBonus, byte payLevel, double yearlyRisePercent) : base(password, username, firstname, lastnames, ssn, baseSalary, christmasBonus)
        {
            PayLevel = payLevel;
            YearlyRisePercent = yearlyRisePercent;
        }

        #endregion
    }
}
