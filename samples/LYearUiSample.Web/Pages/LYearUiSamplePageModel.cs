using LYearUiSample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LYearUiSample.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class LYearUiSamplePageModel : AbpPageModel
    {
        protected LYearUiSamplePageModel()
        {
            LocalizationResourceType = typeof(LYearUiSampleResource);
        }
    }
}