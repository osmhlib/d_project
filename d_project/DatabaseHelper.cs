using d_project;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class DatabaseHelper
{
    private string connectionString = "Data Source=Orders.db;Version=3;";
    private string buffFilePath = "Orders_buff.db";
    private string backupFilePath = $"Orders_backup_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.db";

    public DatabaseHelper()
    {
        InitializeDatabase();
    }
    private void InitializeDatabase()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string createCurrentOrdersTableQuery = @"
            CREATE TABLE IF NOT EXISTS CurrentOrders (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Model TEXT NOT NULL,
                ClientName TEXT NOT NULL,
                Number TEXT NOT NULL,
                ServiceType TEXT NOT NULL,
                Cost REAL NOT NULL,
                ReceptionDate TEXT NOT NULL,
                Prepayment BOOLEAN NOT NULL
            )";
            using (var command = new SQLiteCommand(createCurrentOrdersTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            string createCompletedOrdersTableQuery = @"
            CREATE TABLE IF NOT EXISTS CompletedOrders (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Model TEXT NOT NULL,
                ClientName TEXT NOT NULL,
                Number TEXT NOT NULL,
                ServiceType TEXT NOT NULL,
                Cost REAL NOT NULL,
                ReceptionDate TEXT NOT NULL,
                Prepayment BOOLEAN NOT NULL
            )";
            using (var command = new SQLiteCommand(createCompletedOrdersTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void ConnectToDatabase(string filePath)
    {
        try
        {
            connectionString = $"Data Source={filePath};Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Помилка при підключенні до бази даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public bool CheckDatabaseConnection()
    {
        try
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                return true;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    public void InsertCurrentOrder(string model, string clientName, string number, double cost, string serviceType, string receptionDate, bool prepayment)
    {
        if (!CheckDatabaseConnection())
        {
            return;
        }

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string insertQuery = @"
            INSERT INTO CurrentOrders (Model, ClientName, Number, ServiceType, Cost, ReceptionDate, Prepayment) 
            VALUES (@Model, @ClientName, @Number,  @ServiceType, @Cost, @ReceptionDate, @Prepayment)";
            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@ClientName", clientName);
                command.Parameters.AddWithValue("@Number", number);
                command.Parameters.AddWithValue("@ServiceType", serviceType);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@ReceptionDate", receptionDate);
                command.Parameters.AddWithValue("@Prepayment", prepayment);
                command.ExecuteNonQuery();
            }
        }
    }

    public void InsertCompletedOrder(int id, string model, string clientName, string number, string serviceType, double cost, string receptionDate, bool prepayment)
    {
        if (!CheckDatabaseConnection())
        {
            return;
        }

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string insertQuery = @"
        INSERT INTO CompletedOrders (Id, Model, ClientName, Number, ServiceType, Cost, ReceptionDate, Prepayment) 
        VALUES (@Id, @Model, @ClientName, @Number, @ServiceType, @Cost, @ReceptionDate, @Prepayment)";
            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@ClientName", clientName);
                command.Parameters.AddWithValue("@Number", number);
                command.Parameters.AddWithValue("@ServiceType", serviceType);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@ReceptionDate", receptionDate);
                command.Parameters.AddWithValue("@Prepayment", prepayment);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable GetCurrentOrders()
    {
        if (!CheckDatabaseConnection())
        {
            return null;
        }

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM CurrentOrders";
            using (var command = new SQLiteCommand(selectQuery, connection))
            {
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public DataTable GetCompletedOrders()
    {
        if (!CheckDatabaseConnection())
        {
            return null;
        }

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM CompletedOrders";
            using (var command = new SQLiteCommand(selectQuery, connection))
            {
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public void UpdateOrder(int id, string model, string client, string number, string service, double cost, string date, bool prepayment)
    {
        if (!CheckDatabaseConnection())
        {
            return;
        }

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string updateQuery = @"
            UPDATE CurrentOrders 
            SET Model = @Model, ClientName = @ClientName, Number = @Number, ServiceType = @ServiceType, Cost = @Cost, ReceptionDate = @ReceptionDate, Prepayment = @Prepayment 
            WHERE Id = @Id";
            using (var command = new SQLiteCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@ClientName", client);
                command.Parameters.AddWithValue("@Number", number);
                command.Parameters.AddWithValue("@ServiceType", service);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@ReceptionDate", date);
                command.Parameters.AddWithValue("@Prepayment", prepayment);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteOrder(int id)
    {
        if (!CheckDatabaseConnection())
        {
            return;
        }

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM CurrentOrders WHERE Id = @Id";
            using (var command = new SQLiteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable SearchOrders(string query)
    {
        DataTable results = new DataTable();

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string searchQuery = @"
                SELECT * FROM CurrentOrders 
                WHERE Model LIKE @Query COLLATE NOCASE 
                OR ClientName LIKE @Query COLLATE NOCASE 
                OR Number LIKE @Query COLLATE NOCASE 
                OR ServiceType LIKE @Query COLLATE NOCASE 
                OR ReceptionDate LIKE @Query COLLATE NOCASE 
                OR Id LIKE @Query";

            using (var command = new SQLiteCommand(searchQuery, connection))
            {
                command.Parameters.AddWithValue("@Query", "%" + query + "%");

                using (var adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(results);
                }
            }
        }
        return results;
    }

    public DataTable SearchCompletedOrders(string query)
    {
        DataTable results = new DataTable();

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string searchQuery = @"
                SELECT * FROM CompletedOrders 
                WHERE Model LIKE @Query COLLATE NOCASE 
                OR ClientName LIKE @Query COLLATE NOCASE 
                OR Number LIKE @Query COLLATE NOCASE 
                OR ServiceType LIKE @Query COLLATE NOCASE 
                OR ReceptionDate LIKE @Query COLLATE NOCASE 
                OR Id LIKE @Query";

            using (var command = new SQLiteCommand(searchQuery, connection))
            {
                command.Parameters.AddWithValue("@Query", "%" + query + "%");

                using (var adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(results);
                }
            }
        }
        return results;
    }

    public DatabaseState SaveState()
    {
        DatabaseState state = new DatabaseState();
        state.CurrentOrdersTable = GetCurrentOrders();
        state.CompletedOrdersTable = GetCompletedOrders();

        return state;
    }

    public void CreateBuff()
    {
        File.Copy("Orders.db", buffFilePath, true);
    }

    public void RestoreBuff()
    {
        if (File.Exists(buffFilePath))
        {
            File.Copy(buffFilePath, "Orders.db", true);
            File.Delete(buffFilePath);
        }
    }

    public void ClearCurrentOrders()
    {
        if (!CheckDatabaseConnection())
        {
            return;
        }

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM CurrentOrders";
            using (var command = new SQLiteCommand(deleteQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void ClearCompletedOrders()
    {
        if (!CheckDatabaseConnection())
        {
            return;
        }

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM CompletedOrders";
            using (var command = new SQLiteCommand(deleteQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void CreateBackup()
    {
        File.Copy("Orders.db", backupFilePath, true);
    }

    public bool IsValidDatabase(string filePath)
    {
        try
        {
            string connectionString = $"Data Source={filePath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");

                bool hasCurrentOrdersTable = schema.AsEnumerable().Any(row => row["TABLE_NAME"].ToString().Equals("CurrentOrders", StringComparison.OrdinalIgnoreCase));
                bool hasCompletedOrdersTable = schema.AsEnumerable().Any(row => row["TABLE_NAME"].ToString().Equals("CompletedOrders", StringComparison.OrdinalIgnoreCase));

                if (!hasCurrentOrdersTable || !hasCompletedOrdersTable)
                {
                    return false;
                }
            }
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }
}