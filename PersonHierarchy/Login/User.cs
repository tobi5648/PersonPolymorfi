using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    /// <summary>
    /// The User class
    /// </summary>
    public class User
    {
        //  Here's the fields of the class
        #region Fields

        /// <summary>
        /// The users password
        /// </summary>
        protected string password;

        /// <summary>
        /// The users username
        /// </summary>
        protected string username;

        #endregion

        //  Here's the properties of the class
        #region Properties

        /// <summary>
        /// Gets the password of the user
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">If it isn't a proper password</exception>
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                if (IsPasswordValid(out value) == false)
                    throw new ArgumentOutOfRangeException(value + Environment.NewLine + "try again");
            }
        }

        /// <summary>
        /// Gets the username of the user
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        #endregion

        //  Here's the methods
        #region Methods

        /// <summary>
        /// Checks if the password is valid
        /// </summary>
        /// <param name="errorType"></param>
        /// <returns></returns>
        private bool IsPasswordValid(out string errorType)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                errorType = "Password needs characters";
                password = null;
                return false;
            }
             else if (password.Length > 8)
            {
                errorType = "Password is too long";
                password = null;
                return false;
            }
            else
            {
                errorType = null;
                return true;
            }
        }

        #endregion

        //  Here's the constructors
        #region Constructors

        /// <summary>
        /// Constructor of the class User
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        public User(string password, string username)
        {
            Password = password;
            Username = username;
        }

        #endregion
    }
}
