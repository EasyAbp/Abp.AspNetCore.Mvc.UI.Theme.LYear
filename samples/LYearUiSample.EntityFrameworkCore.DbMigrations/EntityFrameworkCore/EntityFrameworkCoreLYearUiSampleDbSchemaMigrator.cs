using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LYearUiSample.Data;
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
            /* We intentionally resolving the LYearUiSampleMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LYearUiSampleMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}