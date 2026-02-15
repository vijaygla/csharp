using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString = "Server=localhost\\SQLEXPRESS; Database=CollegeDB; Trusted_Connection=True";

    public static void Main(String[] args)
    {
        // call method
        InsertStudentData();
        ReadStudentData();
        UpdateStudentData();
        DeleteStudentData();
    }

    // insert data
    public static void InsertStudentData()
    {
        string query = "INSERT INTO Students(Name, Email) VALUES(@name, @email)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            SqlCommand command1 = new SqlCommand(query, connection);
            command1.Parameters.AddWithValue("@name", "vijay");
            command1.Parameters.AddWithValue("@email", "vijay@gmail.com");
            command1.ExecuteNonQuery();

            // Second Record
            SqlCommand command2 = new SqlCommand(query, connection);
            command2.Parameters.AddWithValue("@name", "vijay kumar");
            command2.Parameters.AddWithValue("@email", "vijaykumar@gmail.com");
            command2.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Data inserted successfully");
        }
    }

    // read data
    public static void ReadStudentData()
    {
        string query = "SELECT * FROM Students";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("==Student Record==");

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["Id"] + " | " +
                    reader["Name"] + " | " +
                    reader["Email"]
                );
            }

            connection.Close();
        }
    }

    // update data
    public static void UpdateStudentData()
    {
        string query = "UPDATE Students SET Name = @name, Email = @email WHERE Id = @id";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", 1);
            command.Parameters.AddWithValue("@name", "updated vijay");
            command.Parameters.AddWithValue("@email", "updatevijay@gmail.com");

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Data updated successfully");
        }
    }

    // delete data
    public static void DeleteStudentData()
    {
        string query = "DELETE FROM Students where Id = @id";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", 2);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Data delete successfully");
        }
    }
}
