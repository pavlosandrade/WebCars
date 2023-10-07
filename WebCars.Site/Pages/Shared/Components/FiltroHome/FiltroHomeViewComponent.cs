using Microsoft.AspNetCore.Mvc;

namespace WebCars.Site.Pages.Shared.Components.FiltroHome
{
    public class FiltroHomeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
