using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.AspNetCore.Mvc.UI.Theme.LYear
{
    [ThemeName(Name)]
    public class LYearTheme : ITheme, ITransientDependency
    {
        public const string Name = "LYear";

        public string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case StandardLayouts.Application:
                    return "~/Themes/LYear/Layouts/Application.cshtml";
                case StandardLayouts.Account:
                    return "~/Themes/LYear/Layouts/Account.cshtml";
                case StandardLayouts.Empty:
                    return "~/Themes/LYear/Layouts/Empty.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/LYear/Layouts/Application.cshtml" : null;
            }
        }
    }
}
