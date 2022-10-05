using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CineminhaXD.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class CineminhaXDDbContextFactory : IDesignTimeDbContextFactory<CineminhaXDDbContext>
{
    public CineminhaXDDbContext CreateDbContext(string[] args)
    {
        CineminhaXDEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<CineminhaXDDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new CineminhaXDDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CineminhaXD.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
