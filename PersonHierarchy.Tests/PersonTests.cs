namespace PersonHierarchy.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests the class Person
    /// </summary>
    [TestClass]
    public class PersonTests
    {
        /// <summary>
        /// A test on the constructor
        /// </summary>
        [TestMethod]
        public void ConstructorPerson()
        {
            //  Arrange
            string expectedPassword = "123456789";
            string expectedUsername = "Tobi5648";
            string expectedFirstname = "Tobias";
            string expectedLastnames = "Bülow";
            string expectedSsn = "0101011234";

            //  Act
            Person person = new Person(expectedPassword, expectedUsername, expectedFirstname, expectedLastnames, expectedSsn);

            //  Assert
            Assert.AreEqual(expectedPassword, person.Password);
            Assert.AreEqual(expectedUsername, person.Username);
            Assert.AreEqual(expectedFirstname, person.Firstname);
            Assert.AreEqual(expectedLastnames, person.Lastnames);
            Assert.AreEqual(expectedSsn, person.Ssn);
        }
    }
}
