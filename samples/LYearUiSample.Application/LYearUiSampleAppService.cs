using System;
using System.Collections.Generic;
using System.Text;
using LYearUiSample.Localization;
using Volo.Abp.Application.Services;

namespace LYearUiSample
{
    /* Inherit your application services from this class.
     */
    public abstract class LYearUiSampleAppService : ApplicationService
    {
        protected LYearUiSampleAppService()
        {
            LocalizationResource = typeof(LYearUiSampleResource);
        }
    }
}
