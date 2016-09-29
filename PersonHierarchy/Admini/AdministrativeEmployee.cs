namespace PersonHierarchy
{
    #region Using
    using System;
    #endregion
    
    #region Class

    /// <summary>
    /// The administrative employee
    /// </summary>
    public class AdministrativeEmployee : Employee
    {
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

        #region Methods

        /// <summary>
        /// A method to get the yearly salary with the yearly rise
        /// </summary>
        /// <returns></returns>
        public override decimal GetYearlySalary()
        {
            decimal newPay = 0;

            for (int i = 1; i <= payLevel; i++)
            {
                newPay += base.GetYearlySalary() * (decimal)yearlyRisePercent;
            }

            return newPay;
        }

        #endregion

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

    #endregion
}
