using EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Bundling;
using EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Toolbars;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcUiThemeSharedModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule))]
    public class AbpAspNetCoreMvcUiLYearThemeModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpAspNetCoreMvcUiLYearThemeModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpThemingOptions>(options =>
            {
                options.Themes.Add<LYearTheme>();

                if (options.DefaultThemeName == null)
                {
                    options.DefaultThemeName = LYearTheme.Name;
                }
            });

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpAspNetCoreMvcUiLYearThemeModule>("Abp.AspNetCore.Mvc.UI.Theme.LYear");
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new LYearThemeMainTopToolbarContributor());
            });

            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .StyleBundles
                    .Add(LYearThemeBundles.Styles.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Styles.Global)
                            .AddContributors(typeof(LYearThemeGlobalStyleContributor));
                    });

                options
                    .ScriptBundles
                    .Add(LYearThemeBundles.Scripts.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Scripts.Global)
                            .AddContributors(typeof(LYearThemeGlobalScriptContributor));
                    });
            });
        }
    }
}
