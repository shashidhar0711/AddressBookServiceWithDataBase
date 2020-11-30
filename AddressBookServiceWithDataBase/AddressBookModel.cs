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
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressBookName { get; set; }
        public string AddressBookType { get; set; }
        public DateTime Start_Date { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookModel"/> class.
        /// </summary>
        /// <param name="FullName">The full name.</param>
        /// <param name="Address">The address.</param>
        /// <param name="City">The city.</param>
        /// <param name="State">The state.</param>
        /// <param name="Zip">The zip.</param>
        /// <param name="PhoneNumber">The phone number.</param>
        /// <param name="Email">The email.</param>
        /// <param name="AddressBookName">Name of the address book.</param>
        /// <param name="AddressBookType">Type of the address book.</param>
        /// <param name="Start_Time">The start time.</param>
        public AddressBookModel(string FullName,string Address,string City,string State,string Zip,string PhoneNumber,string Email,string AddressBookName,string AddressBookType)
        {
            this.FullName = FullName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.AddressBookName = AddressBookName;
            this.AddressBookType = AddressBookType;
            //this.Start_Date = Start_Date;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookModel"/> class.
        /// </summary>
        public AddressBookModel()
        {
        }
    }
}
