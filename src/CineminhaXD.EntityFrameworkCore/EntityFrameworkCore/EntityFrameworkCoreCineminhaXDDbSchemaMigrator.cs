using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CineminhaXD.Data;
using Volo.Abp.DependencyInjection;

namespace CineminhaXD.EntityFrameworkCore;

public class EntityFrameworkCoreCineminhaXDDbSchemaMigrator
    : ICineminhaXDDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCineminhaXDDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CineminhaXDDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CineminhaXDDbContext>()
            .Database
            .MigrateAsync();
    }
}
