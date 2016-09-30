namespace PersonHierarchy.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests for the class User
    /// </summary>
    [TestClass]
    public class UserTests
    {
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
    }
}
