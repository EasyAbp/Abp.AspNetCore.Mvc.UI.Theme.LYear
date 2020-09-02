using System.Threading.Tasks;
using EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Themes.LYear.Components.Toolbar.LanguageSwitch;
using EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Themes.LYear.Components.Toolbar.UserMenu;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.Localization;
using Volo.Abp.Users;

namespace EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Toolbars
{
    public class LYearThemeMainTopToolbarContributor : IToolbarContributor
    {
        public async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name != StandardToolbars.Main)
            {
                return;
            }

            if (!(context.Theme is LYearTheme))
            {
                return;
            }

            var languageProvider = context.ServiceProvider.GetService<ILanguageProvider>();

            //TODO: This duplicates GetLanguages() usage. Can we eleminate this?
            var languages = await languageProvider.GetLanguagesAsync();
            if (languages.Count > 1)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitchViewComponent)));
            }

            if (context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(UserMenuViewComponent)));
            }
        }
    }
}
