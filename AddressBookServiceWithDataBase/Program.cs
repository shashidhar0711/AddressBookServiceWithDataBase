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
            /// Writing query to update
            Console.WriteLine(addressBookRepo.UpdateContactFromTable("update Address_Book set Address = 'Gowtham Nagar' where FullName = 'Madhuri'"));

        }
    }
}
