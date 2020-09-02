using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Abp.AspNetCore.Mvc.UI.Theme.LYear.Bundling
{
    public class LYearThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/lyear/assets/modules/popper.js");
            context.Files.Add("/themes/lyear/assets/modules/tooltip.js");
            context.Files.Add("/themes/lyear/assets/modules/nicescroll/jquery.nicescroll.js");
            context.Files.Add("/themes/lyear/assets/modules/moment.min.js");
        }
    }
}
