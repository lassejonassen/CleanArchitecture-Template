using System.Data.Common;
using Abstractions;
using Microsoft.Data.SqlClient;

namespace Persistence;

public sealed class DbConnectionFactory(string connectionString) : IDbConnectionFactory
{
    public async ValueTask<DbConnection> OpenConnectionAsync()
    {
        var connection = new SqlConnection(connectionString);
        await connection.OpenAsync();
        return connection;
    }
}