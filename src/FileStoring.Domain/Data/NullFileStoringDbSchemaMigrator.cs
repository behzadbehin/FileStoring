using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FileStoring.Data
{
    /* This is used if database provider does't define
     * IFileStoringDbSchemaMigrator implementation.
     */
    public class NullFileStoringDbSchemaMigrator : IFileStoringDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}