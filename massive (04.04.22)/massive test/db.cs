using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace massive_test
{
    class db
    {
        static string ConnectionString = "host=remotemysql.com;port=3306;username=xzCOewO76Q;password=b9mK8pOh06;database=xzCOewO76Q";
        MySqlConnection connection = new MySqlConnection(ConnectionString);

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void ConnectCheck()
        {
            try
            {
            Console.WriteLine("Connecting to MySQL...");
            connection.Open();

            string sql = "select * from sakila.actor limit 0,10;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            //read the data
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
            }
            rdr.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            connection.Close();
            Console.WriteLine("Connection Closed. Press any key to exit...");
            Console.Read();
    }
}
}