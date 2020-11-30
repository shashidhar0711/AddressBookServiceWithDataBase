using AddressBookServiceWithDataBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        [TestMethod]
        public void GivenDataToUpdateDataBase_ItShouldReturnIfExisFalse()
        {
            /// Arrange
            string query = "update Address_Book set Address = 'Gowtham Nagar' where FullName = 'Santosh";
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            /// Act
            bool updateBasicPay = addressBookRepo.UpdateContactFromTable(query);
            /// Assert
            Assert.AreEqual(updateBasicPay, false);
        }

        /// <summary>
        /// Using threads
        /// Givens the contacts to add in to data base using threads.
        /// </summary>
        [TestMethod]
        public void GivenContactsToAddInToDataBase_UsingThreads_ShouldMatchContactEntriesWithThreads()
        {
            List<AddressBookModel> contactList = new List<AddressBookModel>();
            contactList.Add(new AddressBookModel(FullName: "Sridhar", Address: "Anna Nagar", City: "Hoodi", State: "Karnataka", Zip: "560018", PhoneNumber: "9986712839", Email: "sridhar.santosh@gmail.com", AddressBookName: "Film", AddressBookType: "Friends"));
            contactList.Add(new AddressBookModel(FullName: "Shiva", Address: "RD Nagar", City: "Bangarpet", State: "Karnataka", Zip: "563114", PhoneNumber: "9986283918", Email: "shiva.shiran@gmail.com", AddressBookName: "FamilyBook", AddressBookType: "Family"));
            contactList.Add(new AddressBookModel(FullName: "Ranjith", Address: "Bovi Nagar", City: "Halsur", State: "Karnataka", Zip: "563162", PhoneNumber: "9712815839", Email: "ranjith.ran@gmail.com", AddressBookName: "Network", AddressBookType: "professional"));
            contactList.Add(new AddressBookModel(FullName: "Renoy", Address: "Gowtham Nagar", City: "Bangalore", State: "Karnataka", Zip: "563000", PhoneNumber: "9965445589", Email: "renoy.rose@gmail.com", AddressBookName: "Company", AddressBookType: "Friends"));

            AddressBookRepo addressBookRepo = new AddressBookRepo();
            DateTime startDateTime = DateTime.Now;
            addressBookRepo.AddContactsInToDBUsingThreads(contactList);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));
        }
    }
}
