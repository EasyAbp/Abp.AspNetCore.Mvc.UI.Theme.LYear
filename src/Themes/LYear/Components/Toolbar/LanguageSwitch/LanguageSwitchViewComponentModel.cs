using System.Collections.Generic;
using Volo.Abp.Localization;

namespace EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Themes.LYear.Components.Toolbar.LanguageSwitch
{
    public class LanguageSwitchViewComponentModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public List<LanguageInfo> OtherLanguages { get; set; }
    }
}
