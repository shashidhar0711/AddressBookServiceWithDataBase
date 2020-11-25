using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookServiceWithDataBase
{
    /// <summary>
    /// Getters and setters
    /// </summary>
    public class AddressBookModel
    {
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressBookName { get; set; }
        public string AddressBookType { get; set; }
        public DateTime Start_Date { get; set; }
    }
}
