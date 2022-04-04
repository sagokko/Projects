using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        string ConnectionString = "host=remotemysql.com;port=3306;username=xzCOewO76Q;password=b9mK8pOh06;database=xzCOewO76Q";
        MySqlConnection connection = new MySqlConnection(ConnectionString);
        connection.Open();
        MySqlCommand cmd = connection.CreateCommand();
        string sql = "SELECT * FROM `Contact`";
        MySqlCommand command = new MySqlCommand(sql, connection);
        MySqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            for(int i = 0; i < reader.FieldCount; i++)
            {
                Console.WriteLine(reader[i].ToString() + " ");
            }    
        }
        reader.Close();
        connection.Close();
    }
}