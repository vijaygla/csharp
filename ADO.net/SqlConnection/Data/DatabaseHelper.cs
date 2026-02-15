using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace SqlConnection.Data
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Insert data
        public void AddEmployee(string name, decimal salary)
        {
            try
            {
                using (var con = new Microsoft.Data.SqlClient.SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Employees(Name, Salary) VALUES (@name, @salary)";

                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@salary", salary);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }

        // Read data
        public void GetEmployees()
        {
            try
            {
                using (var con = new Microsoft.Data.SqlClient.SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM Employees";

                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["Id"]}  {reader["Name"]}  {reader["Salary"]}");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }
    }
}
