using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.AspNetCore.Mvc.UI.Theme.LYear.Themes.LYear.Components.TopNavbar
{
    public class TopNavbarViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/LYear/Components/TopNavbar/Default.cshtml");
        }
    }
}
