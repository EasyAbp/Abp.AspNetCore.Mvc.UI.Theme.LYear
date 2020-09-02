using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Alerts;

namespace EasyAbp.Abp.AspNetCore.Mvc.UI.Theme.LYear.Themes.LYear.Components.PageAlerts
{
    public class PageAlertsViewComponent : AbpViewComponent
    {
        private readonly IAlertManager _alertManager;

        public PageAlertsViewComponent(IAlertManager alertManager)
        {
            _alertManager = alertManager;
        }

        public IViewComponentResult Invoke(string name)
        {
            return View("~/Themes/LYear/Components/PageAlerts/Default.cshtml", _alertManager.Alerts);
        }
    }
}
