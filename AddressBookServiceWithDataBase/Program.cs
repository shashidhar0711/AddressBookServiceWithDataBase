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
            addressBookModel.FullName = "Shashidhar";
            addressBookModel.Address = "Gowtham Nagar";
            addressBookModel.City = "Bangalore";
            addressBookModel.State = "Gujarat";
            addressBookModel.Zip = "563114";
            addressBookModel.PhoneNumber = "8073112156";
            addressBookModel.Email = "shashidhar.shashi@gmail.com";
            addressBookModel.AddressBookName = "CompanyBook";
            addressBookModel.AddressBookType = "Professional";

            addressBookRepo.AddNewContactInToDataBase(addressBookModel);
            Console.WriteLine("Contact added SuccesFull: "+addressBookModel); 

        }
    }
}
