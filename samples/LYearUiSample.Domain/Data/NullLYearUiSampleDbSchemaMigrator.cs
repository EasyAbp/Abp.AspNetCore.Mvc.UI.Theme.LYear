using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LYearUiSample.Data
{
    /* This is used if database provider does't define
     * ILYearUiSampleDbSchemaMigrator implementation.
     */
    public class NullLYearUiSampleDbSchemaMigrator : ILYearUiSampleDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}