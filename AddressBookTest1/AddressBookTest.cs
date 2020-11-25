using AddressBookServiceWithDataBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressBookTest1
{
    [TestClass]
    public class AddressBookTest
    {
        /// <summary>
        /// Givens the data to update data base it should return if exis true.
        /// </summary>
        [TestMethod]
        public void GivenDataToUpdateDataBase_ItShouldReturnIfExisTrue()
        {
            /// Arrange
            string query = "update Address_Book set Address = 'Gowtham Nagar' where FullName = 'Madhuri'";
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            /// Act
            bool updateBasicPay = addressBookRepo.UpdateContactFromTable(query);
            /// Assert
            Assert.AreEqual(updateBasicPay, true);
        }

        /// <summary>
        /// Givens the data to update data base it should return if exis false.
        /// </summary>
        public void GivenDataToUpdateDataBase_ItShouldReturnIfExisFalse()
        {
            /// Arrange
            string query = "update Address_Book set Address = 'Gowtham Nagar' where FullName = 'Sridhar";
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            /// Act
            bool updateBasicPay = addressBookRepo.UpdateContactFromTable(query);
            /// Assert
            Assert.AreEqual(updateBasicPay, false);
        }
    }
}
