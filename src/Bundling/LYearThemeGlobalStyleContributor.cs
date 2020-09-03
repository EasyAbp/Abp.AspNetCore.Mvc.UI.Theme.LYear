using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Bundling
{
    public class LYearThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.RemoveAll(x => x.Contains("bootstrap.css"));
            context.Files.Add("/themes/lyear/assets/css/bootstrap.min.css");
            context.Files.Add("/themes/lyear/assets/css/materialdesignicons.min.css");
            context.Files.Add("/themes/lyear/assets/css/style.min.css");
            context.Files.Add("/themes/lyear/assets/css/custom.css");
        }
    }
}
