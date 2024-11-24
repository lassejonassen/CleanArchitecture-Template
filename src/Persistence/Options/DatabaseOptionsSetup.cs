using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Persistence.Options;

public class DatabaseOptionsSetup(IConfiguration configuration) : IConfigureOptions<DatabaseOptions>
{
    private const string ConfigurationSectionName = "AppSettings:DatabaseOptions";
    private const string ConnectionStringSectionName = "AppSettings:ConnectionStrings:Database";

    public void Configure(DatabaseOptions options)
    {
        var connectionString = configuration.GetSection(ConnectionStringSectionName).Value;

        ArgumentException.ThrowIfNullOrWhiteSpace(connectionString);

        options.ConnectionString = connectionString;

        configuration.GetSection(ConfigurationSectionName).Bind(options);
    }
}