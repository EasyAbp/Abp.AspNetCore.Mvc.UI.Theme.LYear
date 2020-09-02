using Volo.Abp.Modularity;

namespace LYearUiSample
{
    [DependsOn(
        typeof(LYearUiSampleApplicationModule),
        typeof(LYearUiSampleDomainTestModule)
        )]
    public class LYearUiSampleApplicationTestModule : AbpModule
    {

    }
}