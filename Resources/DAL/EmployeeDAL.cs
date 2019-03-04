using Resources.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.DAL
{
    public class EmployeeDAL
    {
        private SqlConnection connection;
        private Database database;

        public EmployeeDAL()
        {
            database = new Database();
            connection = database.Connection;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string tsql = "SELECT * FROM [CRONUS Sverige AB$Employee]";

            SqlCommand command = new SqlCommand(tsql, connection);

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee emp = new Employee()
                        {
                            No = reader.GetString(reader.GetOrdinal("No_")),
                            FirstName = reader.GetString(reader.GetOrdinal("First Name")),
                            LastName = reader.GetString(reader.GetOrdinal("Last Name")),
                            JobTitle = reader.GetString(reader.GetOrdinal("Job Title")),
                            Address = reader.GetString(reader.GetOrdinal("Address")),
                            City = reader.GetString(reader.GetOrdinal("City")),
                            Phone = reader.GetString(reader.GetOrdinal("Phone No_")),
                            Email = reader.GetString(reader.GetOrdinal("E-Mail")),
                            SSN = reader.GetString(reader.GetOrdinal("Social Security No_"))
                        };

                        employees.Add(emp);
                    }

                    reader.Close();
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return employees;
        }

        // Returns True if employee were successfully deleted.
        public bool RemoveEmployee(string no)
        {
            bool success = false;
            string tsql = "DELETE FROM [CRONUS Sverige AB$Employee] WHERE [No_] = @No_";

            try
            {
                if (database.IsConnect(connection))
                {
                    // Create command and add parameters
                    SqlCommand command = new SqlCommand(tsql, connection);
                    command.Parameters.Add("@No_", SqlDbType.NVarChar).Value = no;

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = (rowsAffected == 1) ? true : false;
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return success;
        }

        // Returns True if customer were successfully created.
        public Boolean CreateEmployee(Employee emp)
        {
            Boolean success = false;
            string tsql = "INSERT INTO [CRONUS Sverige AB$Employee]" +
                                " ([No_], [First Name], [Last Name], [Job Title], [Address], [City], [Phone No_], [E-Mail], [Social Security No_])" +
                          " VALUES(@No_, @FirstName, @LastName, @JobTitle, @Address, @City, @Phone, @Email, @SSN)";

            try
            {
                if (database.IsConnect(connection))
                {
                    // Create command and add parameters
                    SqlCommand command = new SqlCommand(tsql, connection);
                    command.Parameters.Add("@No_", SqlDbType.NVarChar).Value = emp.No;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = emp.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = emp.LastName;
                    command.Parameters.Add("@JobTitle", SqlDbType.NVarChar).Value = emp.JobTitle;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = emp.Address;
                    command.Parameters.Add("@City", SqlDbType.NVarChar).Value = emp.City;
                    command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = emp.Phone;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = emp.Email;
                    command.Parameters.Add("@SSN", SqlDbType.NVarChar).Value = emp.SSN;

                    // Open connection and execute non query
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    success = (rowsAffected == 1) ? true : false;
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return success;
        }

        // Update customer without new password
        public Boolean UpdateEmployee(Employee emp)
        {
            Boolean success = false;
            string tsql = "UPDATE [CRONUS Sverige AB$Employee]" +
                           " SET [First Name] = @FirstName, [Last Name] = @LastName, [Job Title] = @JobTitle," +
                           " [Address] = @Address, [City] = @City, [Phone No_] = @Phone, [E-Mail] = @Email, [Social Security No_] = @SSN" +
                           " WHERE [No_] = @No_";

            try
            {
                if (database.IsConnect(connection))
                {
                    SqlCommand command = new SqlCommand(tsql, connection);

                    // Add parameters to command
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = emp.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = emp.LastName;
                    command.Parameters.Add("@JobTitle", SqlDbType.NVarChar).Value = emp.JobTitle;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = emp.Address;
                    command.Parameters.Add("@City", SqlDbType.NVarChar).Value = emp.City;
                    command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = emp.Phone;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = emp.Email;
                    command.Parameters.Add("@SSN", SqlDbType.NVarChar).Value = emp.SSN;
                    command.Parameters.Add("@No_", SqlDbType.NVarChar).Value = emp.No;
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    success = (rowsAffected == 1) ? true : false;
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return success;
        }

        public string GetEmployeeNameMostAbsence()
        {
            string name = "No Employee Found";
            string tsql = "SELECT TOP(1)" +
                                " COUNT(No_) AS Absence_Count," +
                                " emp.[First Name]" +
                          " FROM[CRONUS Sverige AB$Employee] emp" +
                          " JOIN[CRONUS Sverige AB$Employee Absence] ab" +
                          " ON emp.No_ = ab.[Employee No_]" +
                          " GROUP BY[First Name]" +
                          " ORDER BY Absence_Count DESC";

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(tsql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        name = reader.GetString(reader.GetOrdinal("First Name"));
                    }

                    reader.Close();
                }
            }

            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return name;
        }

        public List<Employee> GetSickEmployeesByYear(string year)
        {
            List<Employee> listOfEmployees = new List<Employee>();
            string tsql = "SELECT DISTINCT [No_], [First Name], [Last Name] FROM [CRONUS Sverige AB$Employee] emp" +
                          " JOIN[CRONUS Sverige AB$Employee Absence] ab" +
                          " ON emp.No_ = ab.[Employee No_]" +
                            " WHERE ab.[Cause of Absence Code] = 'SJUK'" +
                            " AND ab.[From Date] LIKE '%" + year + "%'";

            try
            {
                if (database.IsConnect(connection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(tsql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee emp = new Employee();

                        emp.No = reader.GetString(reader.GetOrdinal("No_"));
                        emp.FirstName = reader.GetString(reader.GetOrdinal("First Name"));
                        emp.LastName = reader.GetString(reader.GetOrdinal("Last Name"));

                        listOfEmployees.Add(emp);
                    }

                    reader.Close();
                }
            }

            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return listOfEmployees;
        }

        public List<Relative> GetRelatives(string empNo)
        {
            List<Relative> relatives = new List<Relative>();
            string tsql = "SELECT * FROM [CRONUS Sverige AB$Employee Relative] WHERE [Employee No_] = @empNo";

            try
            {
                if (database.IsConnect(connection))
                {
                    SqlCommand command = new SqlCommand(tsql, connection);
                    command.Parameters.Add("@empNo", SqlDbType.NVarChar).Value = empNo;
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Relative rel = new Relative()
                        {
                            RelativeCode = reader.GetString(reader.GetOrdinal("Relative Code")),
                            FirstName = reader.GetString(reader.GetOrdinal("First Name")),
                            LastName = reader.GetString(reader.GetOrdinal("Last Name")),
                            BirthDate = reader.GetDateTime(reader.GetOrdinal("Birth Date"))
                        };

                        relatives.Add(rel);
                    }

                    reader.Close();
                }
            }
            catch (SqlException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            catch (InvalidOperationException e)
            {
                ExceptionHandler.HandleErrorException(e);
            }
            finally { database.CloseConnection(connection); }

            return relatives;
        }
    }
}
