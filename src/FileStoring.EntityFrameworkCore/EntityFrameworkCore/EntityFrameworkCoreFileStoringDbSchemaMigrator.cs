using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FileStoring.Data;
using Volo.Abp.DependencyInjection;

namespace FileStoring.EntityFrameworkCore
{
    public class EntityFrameworkCoreFileStoringDbSchemaMigrator
        : IFileStoringDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFileStoringDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FileStoringDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FileStoringDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
