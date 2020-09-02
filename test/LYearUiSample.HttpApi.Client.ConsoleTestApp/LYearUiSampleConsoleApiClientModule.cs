using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LYearUiSample.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(LYearUiSampleHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LYearUiSampleConsoleApiClientModule : AbpModule
    {
        
    }
}
