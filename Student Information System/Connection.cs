using System.Data;
using MySql.Data.MySqlClient;

namespace Student_Information_System;

public abstract class Connection
{

    private const string Server = @"localhost";
    private const string Username = @"public";
    private const string Password = @"public";
    private const string Database = @"student_information";

    public static MySqlConnection GetMySqlConnection()
    {
        var connection = new MySqlConnection();
        connection.ConnectionString = @"server=" + Server + ";username=" + Username + ";password=" + Password +
                                      ";database=" + Database;
        
        try
        {

            if (connection.State.Equals(ConnectionState.Closed))
            {
                connection.Open();
                return connection;
            }
        }
        catch (MySqlException e)
        {
            MessageBox.Show(e.Message);
        }

        return connection;
    }
}