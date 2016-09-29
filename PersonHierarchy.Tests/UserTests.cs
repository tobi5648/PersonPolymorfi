namespace PersonHierarchy.Tests
{
    #region Using

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    #region TestClass

    /// <summary>
    /// Tests for the class User
    /// </summary>
    [TestClass]
    public class UserTests
    {
        #region Constructor

        /// <summary>
        /// Tests the User constructor
        /// </summary>
        [TestMethod]
        public void ConstructorUser()
        {
            //  Arrange
            string expectedPassword = "123456789";
            string expectedUsername = "Tobi5648";

            //  Act
            User user = new User(expectedPassword, expectedUsername);

            //  Assert
            Assert.AreEqual(expectedPassword, user.Password);
            Assert.AreEqual(expectedUsername, user.Username);
        }

        #endregion
    }

    #endregion
}
