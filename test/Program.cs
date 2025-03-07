using System;
using System.Data.SqlClient;


public class Program
{
    public static void Main()
    {

        SqlConnection connection = new();
        connection.ConnectionString = "Data Source=.;Initial Catalog=ACademy;Integrated Security=True";
        connection.Open();

        SqlCommand command = new SqlCommand();

        command.CommandText = "select * from student ";
        command.Connection = connection;

        SqlDataReader sqlDataReader = command.ExecuteReader();
        while (sqlDataReader.Read()) {
            Console.WriteLine($"{sqlDataReader["Name"]} {sqlDataReader["Family"]}");
        }

        connection.Close();

    }

}
