using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Persistence;

public static class DbMigrator
{
    public static void ApplyMigrations(DbContext context)
    {
        Log.Logger.Information("Checking if there are new migrations");

        if (context.Database.GetPendingMigrations().Any())
        {
            try
            {
                Log.Logger.Information("Starting pending migrations");

                context.Database.Migrate();

                Log.Logger.Information("Done migrating.");
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex.Message);
                throw;
            }
        }
        else
        {
            Log.Logger.Information("No migrations found.");
        }
    }
}