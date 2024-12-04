using System.Data;
using Npgsql;

namespace Responsi_2_Junior_Project
{
    public class DbContext : IDisposable
    {
        private readonly string _connectionString;
        private NpgsqlConnection _connection;

        public DbContext(string host = "localhost", string port = "5432",
            string database = "responsi-2-junpro", string user = "postgres", string password = "12345678")
        {
            _connectionString = $"Host={host}; Port={port}; Username={user}; Password={password}; Database={database}";
        }

        public NpgsqlConnection GetConnection()
        {
            _connection = new NpgsqlConnection(_connectionString);
            return _connection;
        }

        public async Task<bool> TestConnectionAsync()
        {
            try
            {
                using var conn = GetConnection();
                await conn.OpenAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}