using System;
using System.Threading.Tasks;
using LYearUiSample.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace LYearUiSample.EntityFrameworkCore
{
    public class EntityFrameworkCoreLYearUiSampleDbSchemaMigrator
        : ILYearUiSampleDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLYearUiSampleDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LYearUiSampleDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LYearUiSampleDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
