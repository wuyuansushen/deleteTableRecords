using System;
using System.Linq;
using MySqlConnector;

namespace deleteTableRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDelete;
            using(var connection=new MySqlConnection("server=localhost;user=root;password=1234567890;database=ef"))
            {
                connection.Open();
                using var command = new MySqlCommand("DELETE FROM Auth;", connection);
                totalDelete = command.ExecuteNonQuery();
            }
            Console.WriteLine($"Delete {totalDelete} rows");
        }
    }
}
