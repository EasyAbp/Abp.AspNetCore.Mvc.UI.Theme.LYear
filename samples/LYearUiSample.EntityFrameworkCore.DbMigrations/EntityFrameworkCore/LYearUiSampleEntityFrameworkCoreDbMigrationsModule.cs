using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LYearUiSample.EntityFrameworkCore
{
    [DependsOn(
        typeof(LYearUiSampleEntityFrameworkCoreModule)
        )]
    public class LYearUiSampleEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LYearUiSampleMigrationsDbContext>();
        }
    }
}
