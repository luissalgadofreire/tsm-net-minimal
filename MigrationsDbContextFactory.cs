using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TheSaultyMonk.Minimal.Representation;

public class
    DesignTimeMigrationsDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        const string connectionString =
            "host=localhost;port=9999;database=db;username=user;password=password;";
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();

        var context =
            (ApplicationDbContext)Activator.CreateInstance(typeof(ApplicationDbContext),
                optionsBuilder.Options)!;

        return context;
    }
}