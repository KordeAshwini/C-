using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RetrieveSqlDataReader
{
    class ShowData
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=localhost;userid=root;password=;Database=demo";
            MySqlConnection conn = null; MySqlDataReader Reader = null;
            conn = new MySqlConnection(connectionString);
            conn.Open();
            Console.WriteLine("\nRetrieving data from database MySql wamp server\n");
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM student";
                Reader = cmd.ExecuteReader();
                Console.WriteLine("ID|Name|Percentage\n");
                while (Reader.Read())
                {
                    Console.WriteLine(Reader.GetString(0) + "|" + Reader.GetString(1) + "|" + Reader.GetString(2));
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                if (Reader != null)
                {
                    Reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
