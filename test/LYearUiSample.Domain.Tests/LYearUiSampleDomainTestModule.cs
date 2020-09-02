using LYearUiSample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LYearUiSample
{
    [DependsOn(
        typeof(LYearUiSampleEntityFrameworkCoreTestModule)
        )]
    public class LYearUiSampleDomainTestModule : AbpModule
    {

    }
}