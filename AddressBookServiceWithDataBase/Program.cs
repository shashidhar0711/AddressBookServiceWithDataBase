﻿using System;

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
            AddressBookModel fdf = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.GetAllRecordsOfContacts("select * from Address_Book");

        }
    }
}