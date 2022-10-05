using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CineminhaXD.Data;

/* This is used if database provider does't define
 * ICineminhaXDDbSchemaMigrator implementation.
 */
public class NullCineminhaXDDbSchemaMigrator : ICineminhaXDDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
