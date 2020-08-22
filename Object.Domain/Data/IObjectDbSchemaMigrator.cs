using System.Threading.Tasks;

namespace Object.Domain.Data
{
    public interface IObjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}