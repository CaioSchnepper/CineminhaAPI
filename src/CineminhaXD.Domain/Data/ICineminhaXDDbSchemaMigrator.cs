using System.Threading.Tasks;

namespace CineminhaXD.Data;

public interface ICineminhaXDDbSchemaMigrator
{
    Task MigrateAsync();
}
