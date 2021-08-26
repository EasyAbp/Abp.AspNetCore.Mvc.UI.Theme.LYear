using LYearUiSample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LYearUiSample.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LYearUiSampleEntityFrameworkCoreModule),
        typeof(LYearUiSampleApplicationContractsModule)
        )]
    public class LYearUiSampleDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
