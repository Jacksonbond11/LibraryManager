using Microsoft.Data.Sqlite;
class Database
{
    public void CreateTable(string query)
    {
        string connectionString = "Data Source=database.sqlite;";

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            string createTableQuery = query;

            using (var command = new SqliteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Table 'Users' created successfully.");
        }
    }
}