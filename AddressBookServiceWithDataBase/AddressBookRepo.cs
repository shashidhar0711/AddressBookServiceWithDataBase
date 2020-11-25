using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookServiceWithDataBase
{
    public class AddressBookRepo
    {
        /// Establishing the connection
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
                    SqlDataReader dataReader = command.ExecuteReader();
                    /// If not null
                    /// Read all data form database
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            addressBookModel.ContactId = dataReader.GetInt32(0);
                            addressBookModel.FullName = dataReader.GetString(1);
                            addressBookModel.Address = dataReader.GetString(3);
                            addressBookModel.City = dataReader.GetString(4);
                            addressBookModel.State = dataReader.GetString(5);
                            addressBookModel.PhoneNumber = dataReader.GetString(6);
                            addressBookModel.Zip = dataReader.GetString(7);
                            addressBookModel.Email = dataReader.GetString(8);

                            Console.WriteLine(addressBookModel.ContactId + " , " + addressBookModel.FullName + " , " + addressBookModel.Address + "\t"
                            +addressBookModel.City + " , " + addressBookModel.State + " , " + addressBookModel.PhoneNumber + " , " + addressBookModel.Zip + " , " + addressBookModel.Email);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data Not Found");
                    }
                    dataReader.Close();
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

        /// <summary>
        /// Retrieve contact with in date range.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public void RetrieveContactWithinDateRange(string query)
        {
            try
            {
                /// Creating instance of object class
                AddressBookModel addressBookModel = new AddressBookModel();
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand(query, this.connection);
                    /// Connection opens
                    this.connection.Open();
                    /// Executing the sql query
                    SqlDataReader dataReader = command.ExecuteReader();
                    /// If not null
                    /// Read all data form database
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            addressBookModel.ContactId = dataReader.GetInt32(0);
                            addressBookModel.FullName = dataReader.GetString(1);
                            addressBookModel.Address = dataReader.GetString(2);
                            addressBookModel.City = dataReader.GetString(3);
                            addressBookModel.State = dataReader.GetString(4);
                            addressBookModel.PhoneNumber = dataReader.GetString(5);
                            addressBookModel.Zip = dataReader.GetString(6);
                            addressBookModel.Email = dataReader.GetString(7);
                            addressBookModel.AddressBookName = dataReader.GetString(8);
                            addressBookModel.AddressBookType = dataReader.GetString(9);
                            addressBookModel.Start_Date = dataReader.GetDateTime(10);

                            Console.WriteLine(addressBookModel.ContactId + " , " + addressBookModel.FullName + " , " + addressBookModel.Address + " , "
                            + addressBookModel.City + " , " + addressBookModel.State + " , " + addressBookModel.PhoneNumber + " , " + addressBookModel.Zip + " , " 
                            + addressBookModel.Email+" , "+addressBookModel.AddressBookName+" , "+addressBookModel.AddressBookType+" , "+addressBookModel.Start_Date);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");
                    }
                    dataReader.Close();
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
        /// Retrieve contact data by givens city.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public void RetrieveContactDataByGivenCity(string query)
        {
            try
            {
                /// Creating instance of object class
                AddressBookModel addressBookModel = new AddressBookModel();
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand(query, this.connection);
                    /// Connection opens
                    this.connection.Open();
                    /// Executing the sql query
                    SqlDataReader dataReader = command.ExecuteReader();
                    /// If not null
                    /// Read all data form database
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            addressBookModel.ContactId = dataReader.GetInt32(0);
                            addressBookModel.FullName = dataReader.GetString(1);
                            addressBookModel.Address = dataReader.GetString(2);
                            addressBookModel.City = dataReader.GetString(3);
                            addressBookModel.State = dataReader.GetString(4);
                            addressBookModel.PhoneNumber = dataReader.GetString(5);
                            addressBookModel.Zip = dataReader.GetString(6);
                            addressBookModel.Email = dataReader.GetString(7);
                            addressBookModel.AddressBookName = dataReader.GetString(8);
                            addressBookModel.AddressBookType = dataReader.GetString(9);
                            addressBookModel.Start_Date = dataReader.GetDateTime(10);

                            Console.WriteLine(addressBookModel.ContactId + " , " + addressBookModel.FullName + " , " + addressBookModel.Address + " , "
                            + addressBookModel.City + " , " + addressBookModel.State + " , " + addressBookModel.PhoneNumber + " , " + addressBookModel.Zip + " , "
                            + addressBookModel.Email + " , " + addressBookModel.AddressBookName + " , " + addressBookModel.AddressBookType + " , " + addressBookModel.Start_Date);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");
                    }
                    dataReader.Close();
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
    }
}
