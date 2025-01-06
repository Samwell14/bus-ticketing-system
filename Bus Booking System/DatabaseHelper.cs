using MySql.Data.MySqlClient;
using System.Data.SqlClient;

public class DatabaseHelper
{
    private string connectionString = "server=localhost;database=bus_ticketing_system;user=root;password=Samii@122";

    public bool RegisterUser(string name, string fatherName, decimal cnic, string gender, string password, string city)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Users (Name, FatherName, CNIC, Gender, Password, City) VALUES (@Name, @FatherName, @CNIC, @Gender, @Password, @City)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@FatherName", fatherName);
            cmd.Parameters.AddWithValue("@CNIC", cnic);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@City", city);
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
    }
}