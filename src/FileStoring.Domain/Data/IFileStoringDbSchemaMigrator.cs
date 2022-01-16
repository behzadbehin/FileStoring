using System.Threading.Tasks;

namespace FileStoring.Data
{
    public interface IFileStoringDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
