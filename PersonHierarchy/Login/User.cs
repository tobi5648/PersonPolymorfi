using System;
using System.Collections.Generic;   // Kommentar
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
                if (!IsValidPassword(value))
                {
                    throw new ArgumentOutOfRangeException(value + Environment.NewLine + "try again");
                }
                else if (IsValidPassword(value))
                    password = value;
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
        private static bool IsPasswordValid(string password, out string errorType)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                errorType = "Password needs characters";
                return false;
            }
             else if (password.Length < 8)
            {
                errorType = "Password is too short";
                return false;
            }
            else
            {
                errorType = null;
                return true;
            }
        }

        private static bool IsValidPassword(string password)
        {
            string error = String.Empty;
            try
            {
                return IsPasswordValid(password, out error);
            }
            catch (ArgumentException) { throw; }
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
            try
            {
                Password = password;
                Username = username;
            }
            catch (ArgumentOutOfRangeException) { throw; }
            catch (ArgumentException) { throw; }
        }

        #endregion
    }
}
