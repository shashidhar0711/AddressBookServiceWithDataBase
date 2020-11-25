using System;

namespace AddressBookServiceWithDataBase
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Service");
            AddressBookModel addressBookModel = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            /// Writing query to get contact by giving city
            addressBookRepo.RetrieveContactDataByGivenCity("select * from Address_Book where City = 'Bangarpet'");

        }
    }
}
