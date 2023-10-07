using Microsoft.AspNetCore.Mvc;

namespace WebCars.Site.Pages.Shared.Components.BannerHome
{
    public class BannerHomeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
