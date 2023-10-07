using Microsoft.AspNetCore.Mvc;

namespace WebCars.Site.Pages.Shared.Components.BannerFicha
{
    public class BannerFichaViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
