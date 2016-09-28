using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    /// <summary>
    /// The Person class
    /// </summary>
    public class Person : User
    {
        //  Here's the fields of the class
        #region Fields

        /// <summary>
        /// The firstname of the user
        /// </summary>
        protected string firstname;

        /// <summary>
        /// The lastname/s of the user
        /// </summary>
        protected string lastnames;

        /// <summary>
        /// The social security number of the user
        /// </summary>
        protected string ssn;

        #endregion
        
        #region Properties

        /// <summary>
        /// Gets or sets the firstname of the user
        /// </summary>
        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        /// <summary>
        /// Gets or sets the lastname/s of the user
        /// </summary>
        public string Lastnames
        {
            get
            {
                return lastnames;
            }

            set
            {
                lastnames = value;
            }
        }

        /// <summary>
        /// Gets or sets the social security of the user
        /// </summary>
        public string Ssn
        {
            get
            {
                return ssn;
            }

            set
            {
                ssn = value;
                if (IsSsnValid(out value) == false)
                    throw new ArgumentOutOfRangeException(value + Environment.NewLine + "try again");
            }
        }

        #endregion
        
        #region Methods

        /// <summary>
        /// Checks if the social security number is valid
        /// </summary>
        /// <param name="errorType"></param>
        /// <returns></returns>
        public bool IsSsnValid(out string errorType)
        {
            if (string.IsNullOrWhiteSpace(ssn))
            {
                errorType = "Social security number needs characters";
                ssn = null;
                return false;
            }
            else if (password.Length > 10)
            {
                errorType = "Social security number is too long";
                ssn = null;
                return false;
            }
            else if (ssn.Any(char.IsLetter))
            {
                errorType = "Social security numbers doesn't have letters";
                ssn = null;
                return false;
            }
            else
            {
                errorType = null;
                return true;
            }
        }

        #endregion
        
        #region Constructors

        /// <summary>
        /// The Constructor of the class Person
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="firstname"></param>
        /// <param name="lastnames"></param>
        public Person (string password, string username, string firstname, string lastnames, string ssn) : base(password, username)
        {
            Firstname = firstname;
            Lastnames = lastnames;
            Ssn = ssn;
        }
        
        #endregion
    }
}
