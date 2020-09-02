using LYearUiSample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LYearUiSample.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LYearUiSampleController : AbpController
    {
        protected LYearUiSampleController()
        {
            LocalizationResource = typeof(LYearUiSampleResource);
        }
    }
}