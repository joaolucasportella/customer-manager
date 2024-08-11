using System.Data;
using System.Data.SQLite;

namespace CustomerManagement
{
    public static class Database
    {
        public static DataTable? customersTable;

        private static readonly string sqlDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sql");
        private static readonly string specialDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string databaseDirectoryPath = Path.Combine(specialDirectoryPath, "Portella");
        private static readonly string databaseFilePath = Path.Combine(databaseDirectoryPath, "customer_management.db");
        private static readonly string connectionString = $"Data Source={databaseFilePath};Version=3;";

        public static void CreateDatabaseIfNotExists()
        {
            try
            {
                if (!Directory.Exists(databaseDirectoryPath))
                {
                    Directory.CreateDirectory(databaseDirectoryPath);
                }

                if (!File.Exists(databaseFilePath))
                {
                    SQLiteConnection.CreateFile(databaseFilePath);

                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        ExecuteSqlFromFile(connection, "createCustomersTable.sql");
                        ExecuteSqlFromFile(connection, "createAnamneseTable.sql");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    text: $"Erro ao criar banco de dados: {ex.Message}",
                    caption: "Erro",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
                Application.Exit();
            }
        }

        public static void LoadData()
        {
            try
            {
                string sql = ReadSqlFile("fetchCustomerAndAnamnese.sql");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (var adapter = new SQLiteDataAdapter(sql, connection))
                    {
                        customersTable = new DataTable();
                        adapter.Fill(customersTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    text: $"Erro ao carregar dados: {ex.Message}",
                    caption: "Erro",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
                Application.Exit();
            }
        }

        public static void InsertCustomerAndAnamnese(
            string name,
            string rg,
            string cpf,
            string address,
            string cep,
            string city,
            string email,
            string phone1,
            string phone2,
            string birthDate,
            bool previousEstheticTreatment,
            string specifyPreviousEstheticTreatment,
            bool allergies,
            string specifyAllergies,
            bool regularIntestinalFunction,
            string specifyRegularIntestinalFunction,
            bool practiceSports,
            string specifyPracticeSports,
            bool balancedDiet,
            string specifyBalancedDiet,
            bool medicalTreatment,
            string specifyMedicalTreatment,
            bool useMedications,
            string specifyUseMedications,
            bool pacemaker,
            string specifyPacemaker,
            bool metalProstheses,
            string specifyMetalProstheses,
            bool heartProblems,
            string specifyHeartProblems,
            bool oncologicalHistory,
            string specifyOncologicalHistory,
            bool menstrualCycle,
            string specifyMenstrualCycle,
            bool contraceptiveMethod,
            string specifyContraceptiveMethod,
            bool dailyCareProducts,
            string specifyDailyCareProducts,
            bool pregnant,
            bool hasChildren,
            int childrenQuantity,
            bool smoke,
            bool epilepsy,
            bool diabetes,
            bool dentalProsthesis,
            bool sunExposure,
            bool hypertensive
        )
        {
            ExecuteNonQueryFromFile(
                "insertCustomerAndAnamnese.sql",
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
                ("@previousEstheticTreatment", previousEstheticTreatment),
                ("@specifyPreviousEstheticTreatment", specifyPreviousEstheticTreatment),
                ("@allergies", allergies),
                ("@specifyAllergies", specifyAllergies),
                ("@regularIntestinalFunction", regularIntestinalFunction),
                ("@specifyRegularIntestinalFunction", specifyRegularIntestinalFunction),
                ("@practiceSports", practiceSports),
                ("@specifyPracticeSports", specifyPracticeSports),
                ("@balancedDiet", balancedDiet),
                ("@specifyBalancedDiet", specifyBalancedDiet),
                ("@medicalTreatment", medicalTreatment),
                ("@specifyMedicalTreatment", specifyMedicalTreatment),
                ("@useMedications", useMedications),
                ("@specifyUseMedications", specifyUseMedications),
                ("@pacemaker", pacemaker),
                ("@specifyPacemaker", specifyPacemaker),
                ("@metalProstheses", metalProstheses),
                ("@specifyMetalProstheses", specifyMetalProstheses),
                ("@heartProblems", heartProblems),
                ("@specifyHeartProblems", specifyHeartProblems),
                ("@oncologicalHistory", oncologicalHistory),
                ("@specifyOncologicalHistory", specifyOncologicalHistory),
                ("@menstrualCycle", menstrualCycle),
                ("@specifyMenstrualCycle", specifyMenstrualCycle),
                ("@contraceptiveMethod", contraceptiveMethod),
                ("@specifyContraceptiveMethod", specifyContraceptiveMethod),
                ("@dailyCareProducts", dailyCareProducts),
                ("@specifyDailyCareProducts", specifyDailyCareProducts),
                ("@pregnant", pregnant),
                ("@hasChildren", hasChildren),
                ("@childrenQuantity", childrenQuantity),
                ("@smoke", smoke),
                ("@epilepsy", epilepsy),
                ("@diabetes", diabetes),
                ("@dentalProsthesis", dentalProsthesis),
                ("@sunExposure", sunExposure),
                ("@hypertensive", hypertensive)
            );
            LoadData();
        }

        public static void UpdateCustomerAndAnamnese(
            int id,
            string name,
            string rg,
            string cpf,
            string address,
            string cep,
            string city,
            string email,
            string phone1,
            string phone2,
            string birthDate,
            bool previousEstheticTreatment,
            string specifyPreviousEstheticTreatment,
            bool allergies,
            string specifyAllergies,
            bool regularIntestinalFunction,
            string specifyRegularIntestinalFunction,
            bool practiceSports,
            string specifyPracticeSports,
            bool balancedDiet,
            string specifyBalancedDiet,
            bool medicalTreatment,
            string specifyMedicalTreatment,
            bool useMedications,
            string specifyUseMedications,
            bool pacemaker,
            string specifyPacemaker,
            bool metalProstheses,
            string specifyMetalProstheses,
            bool heartProblems,
            string specifyHeartProblems,
            bool oncologicalHistory,
            string specifyOncologicalHistory,
            bool menstrualCycle,
            string specifyMenstrualCycle,
            bool contraceptiveMethod,
            string specifyContraceptiveMethod,
            bool dailyCareProducts,
            string specifyDailyCareProducts,
            bool pregnant,
            bool hasChildren,
            int childrenQuantity,
            bool smoke,
            bool epilepsy,
            bool diabetes,
            bool dentalProsthesis,
            bool sunExposure,
            bool hypertensive
        )
        {
            ExecuteNonQueryFromFile(
                "updateCustomerAndAnamnese.sql",
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
                ("@previousEstheticTreatment", previousEstheticTreatment),
                ("@specifyPreviousEstheticTreatment", specifyPreviousEstheticTreatment),
                ("@allergies", allergies),
                ("@specifyAllergies", specifyAllergies),
                ("@regularIntestinalFunction", regularIntestinalFunction),
                ("@specifyRegularIntestinalFunction", specifyRegularIntestinalFunction),
                ("@practiceSports", practiceSports),
                ("@specifyPracticeSports", specifyPracticeSports),
                ("@balancedDiet", balancedDiet),
                ("@specifyBalancedDiet", specifyBalancedDiet),
                ("@medicalTreatment", medicalTreatment),
                ("@specifyMedicalTreatment", specifyMedicalTreatment),
                ("@useMedications", useMedications),
                ("@specifyUseMedications", specifyUseMedications),
                ("@pacemaker", pacemaker),
                ("@specifyPacemaker", specifyPacemaker),
                ("@metalProstheses", metalProstheses),
                ("@specifyMetalProstheses", specifyMetalProstheses),
                ("@heartProblems", heartProblems),
                ("@specifyHeartProblems", specifyHeartProblems),
                ("@oncologicalHistory", oncologicalHistory),
                ("@specifyOncologicalHistory", specifyOncologicalHistory),
                ("@menstrualCycle", menstrualCycle),
                ("@specifyMenstrualCycle", specifyMenstrualCycle),
                ("@contraceptiveMethod", contraceptiveMethod),
                ("@specifyContraceptiveMethod", specifyContraceptiveMethod),
                ("@dailyCareProducts", dailyCareProducts),
                ("@specifyDailyCareProducts", specifyDailyCareProducts),
                ("@pregnant", pregnant),
                ("@hasChildren", hasChildren),
                ("@childrenQuantity", childrenQuantity),
                ("@smoke", smoke),
                ("@epilepsy", epilepsy),
                ("@diabetes", diabetes),
                ("@dentalProsthesis", dentalProsthesis),
                ("@sunExposure", sunExposure),
                ("@hypertensive", hypertensive),
                ("@id", id)
            );
            LoadData();
        }

        private static string ReadSqlFile(string fileName)
        {
            string sqlFilePath = Path.Combine(sqlDirectoryPath, fileName);

            if (!File.Exists(sqlFilePath))
            {
                throw new FileNotFoundException($"SQL file not found: {fileName}");
            }

            return File.ReadAllText(sqlFilePath);
        }

        private static void ExecuteSqlFromFile(SQLiteConnection connection, string fileName)
        {
            string sql = ReadSqlFile(fileName);

            using (var command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static void ExecuteNonQueryFromFile(string fileName, params (string ParameterName, object Value)[] parameters)
        {
            string sql = ReadSqlFile(fileName);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

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

        private static List<Dictionary<string, object>> ExecuteQueryFromFile(string fileName, params (string ParameterName, object Value)[] parameters)
        {
            var results = new List<Dictionary<string, object>>();

            string sql = ReadSqlFile(fileName);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

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
