using Microsoft.AspNetCore.Mvc;

namespace WebCars.Site.Pages.Shared.Components.CategoriasHome
{
    public class CategoriasHomeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
