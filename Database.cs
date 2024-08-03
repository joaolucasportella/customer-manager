using System.Data.SQLite;

namespace CustomerManagement
{
    public class Database
    {
        private static readonly string connectionString = "Data Source=clientes.db;Version=3;";
        private static readonly string sqlDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sql");

        public Database()
        {
            CreateDatabaseIfNotExists();
        }

        private void CreateDatabaseIfNotExists()
        {
            if (!File.Exists("clientes.db"))
            {
                SQLiteConnection.CreateFile("clientes.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    ExecuteSqlFromFile(connection, "createCustomersTable.sql");
                    ExecuteSqlFromFile(connection, "createAnamneseTable.sql");
                }
            }
        }

        private void ExecuteSqlFromFile(SQLiteConnection connection, string fileName)
        {
            string sqlFilePath = Path.Combine(sqlDirectory, fileName);

            if (!File.Exists(sqlFilePath))
            {
                throw new FileNotFoundException($"SQL file not found: {fileName}");
            }

            string sql = File.ReadAllText(sqlFilePath);

            using (var command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void InsertCustomer(string name, string rg, string cpf, string address, string cep, string city, string email, string phone1, string phone2, string birthDate)
        {
            ExecuteNonQueryFromFile(
                "insertCustomer.sql",
                ("@name", name),
                ("@rg", rg),
                ("@cpf", cpf),
                ("@address", address),
                ("@cep", cep),
                ("@city", city),
                ("@email", email),
                ("@phone1", phone1),
                ("@phone2", phone2),
                ("@birthDate", birthDate)
            );
        }

        public void UpdateCustomer(int id, string name, string rg, string cpf, string address, string cep, string city, string email, string phone1, string phone2, string birthDate)
        {
            ExecuteNonQueryFromFile(
                "updateCustomer.sql",
                ("@name", name),
                ("@rg", rg),
                ("@cpf", cpf),
                ("@address", address),
                ("@cep", cep),
                ("@city", city),
                ("@email", email),
                ("@phone1", phone1),
                ("@phone2", phone2),
                ("@birthDate", birthDate),
                ("@id", id)
            );
        }

        private void ExecuteNonQueryFromFile(string fileName, params (string ParameterName, object Value)[] parameters)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sqlFilePath = Path.Combine(sqlDirectory, fileName);

                if (!File.Exists(sqlFilePath))
                {
                    throw new FileNotFoundException($"SQL file not found: {fileName}");
                }

                string sql = File.ReadAllText(sqlFilePath);

                using (var command = new SQLiteCommand(sql, connection))
                {
                    foreach (var (parameterName, value) in parameters)
                    {
                        if (value is string str && string.IsNullOrEmpty(str))
                        {
                            command.Parameters.AddWithValue(parameterName, DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue(parameterName, value ?? DBNull.Value);
                        }
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        private List<Dictionary<string, object>> ExecuteQueryFromFile(string fileName, params (string ParameterName, object Value)[] parameters)
        {
            var results = new List<Dictionary<string, object>>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sqlFilePath = Path.Combine(sqlDirectory, fileName);

                if (!File.Exists(sqlFilePath))
                {
                    throw new FileNotFoundException($"SQL file not found: {fileName}");
                }

                string sql = File.ReadAllText(sqlFilePath);

                using (var command = new SQLiteCommand(sql, connection))
                {
                    foreach (var (parameterName, value) in parameters)
                    {
                        if (value is string str && string.IsNullOrEmpty(str))
                        {
                            command.Parameters.AddWithValue(parameterName, DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue(parameterName, value ?? DBNull.Value);
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        var columnNames = new List<string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            columnNames.Add(reader.GetName(i));
                        }

                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            foreach (var columnName in columnNames)
                            {
                                row[columnName] = reader[columnName];
                            }
                            results.Add(row);
                        }
                    }
                }
            }

            return results;
        }
    }
}
