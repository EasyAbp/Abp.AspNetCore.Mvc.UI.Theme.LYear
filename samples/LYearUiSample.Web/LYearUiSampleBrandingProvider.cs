using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LYearUiSample.Web
{
    [Dependency(ReplaceServices = true)]
    public class LYearUiSampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LYearUiSample";
    }
}
