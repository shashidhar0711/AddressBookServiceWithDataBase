using System;
using System.Collections.Generic;

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
            addressBookModel.Start_Date = Convert.ToDateTime("2020-01-27");

            //addressBookRepo.AddNewContactInToDataBase(addressBookModel);
            //Console.WriteLine("Contact added SuccesFull: "); 

            List<AddressBookModel> contactList = new List<AddressBookModel>();
            contactList.Add(new AddressBookModel(FullName: "Sridhar", Address: "Anna Nagar", City: "Hoodi", State: "Karnataka", Zip: "560018", PhoneNumber: "9986712839", Email: "sridhar.santosh@gmail.com", AddressBookName: "Film", AddressBookType: "Friends"));
            contactList.Add(new AddressBookModel(FullName: "Shiva", Address: "RD Nagar", City: "Bangarpet", State: "Karnataka", Zip: "563114", PhoneNumber: "9986283918", Email: "shiva.shiran@gmail.com", AddressBookName: "FamilyBook", AddressBookType: "Family"));
            contactList.Add(new AddressBookModel(FullName: "Ranjith", Address: "Bovi Nagar", City: "Halsur", State: "Karnataka", Zip: "563162", PhoneNumber: "9712815839", Email: "ranjith.ran@gmail.com", AddressBookName: "Network", AddressBookType: "professional"));
            contactList.Add(new AddressBookModel(FullName: "Renoy", Address: "Gowtham Nagar", City: "Bangalore", State: "Karnataka", Zip: "563000", PhoneNumber: "9965445589", Email: "renoy.rose@gmail.com", AddressBookName: "Company", AddressBookType: "Friends"));

            addressBookRepo.AddContactsInToDBUsingThreads(contactList);
            Console.WriteLine("Contact added SuccesFull: "); 
        }
    }
}
