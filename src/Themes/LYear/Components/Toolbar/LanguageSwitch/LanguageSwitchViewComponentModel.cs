using System.Collections.Generic;
using Volo.Abp.Localization;

namespace EasyAbp.AspNetCore.Mvc.UI.Theme.LYear.Themes.LYear.LanguageSwitch
{
    public class LanguageSwitchViewComponentModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public List<LanguageInfo> OtherLanguages { get; set; }
    }
}
