using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace LYearUiSample.Web
{
    [Dependency(ReplaceServices = true)]
    public class LYearUiSampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LYearUiSample";
    }
}
