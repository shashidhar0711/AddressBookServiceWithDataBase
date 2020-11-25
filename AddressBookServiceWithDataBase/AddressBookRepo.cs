using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookServiceWithDataBase
{
    public class AddressBookRepo
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        /// <summary>
        /// Gets all records of contacts.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void GetAllRecordsOfContacts(string query)
        {
            try
            {
                /// Creating instance of object class
                AddressBookModel addressBookModel = new AddressBookModel();
                using (this.connection)
                {
                    /// Writing sql query
                    SqlCommand command = new SqlCommand(query, this.connection);
                    /// Connection opens
                    this.connection.Open();
                    /// Executing the sql query
                    SqlDataReader reader = command.ExecuteReader();
                    /// If not null
                    /// Read all data form database
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            addressBookModel.ContactId = reader.GetInt32(0);
                            addressBookModel.FullName = reader.GetString(1);
                            addressBookModel.Address = reader.GetString(3);
                            addressBookModel.City = reader.GetString(4);
                            addressBookModel.State = reader.GetString(5);
                            addressBookModel.PhoneNumber = reader.GetString(6);
                            addressBookModel.Zip = reader.GetInt32(7);
                            addressBookModel.Email = reader.GetString(8);

                            Console.WriteLine(addressBookModel.ContactId + " , " + addressBookModel.FullName + " , " + addressBookModel.Address + "\t"
                            +addressBookModel.City + " , " + addressBookModel.State + " , " + addressBookModel.PhoneNumber + " , " + addressBookModel.Zip + " , " + addressBookModel.Email);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data Not Found");
                    }
                    reader.Close();
                    /// Connection closes
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        /// <summary>
        /// Updates the contact from table.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public bool UpdateContactFromTable(string query)
        {
            using (this.connection)
            {
                try
                {
                    this.connection.Open();
                    SqlCommand command = this.connection.CreateCommand();
                    /// Gets or sets the sql statement to execute at the data base
                    command.CommandText = query;
                    /// It is used to executing the query and it does not return data
                    /// Instead Returns number of rows effected
                    int numberOfEffectedRows = command.ExecuteNonQuery();
                    if (numberOfEffectedRows != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    this.connection.Close();
                }
            }
        }
    }
}
