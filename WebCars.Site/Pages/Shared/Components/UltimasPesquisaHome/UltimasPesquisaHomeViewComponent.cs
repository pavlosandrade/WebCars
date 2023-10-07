using Microsoft.AspNetCore.Mvc;

namespace WebCars.Site.Pages.Shared.Components.UltimasPesquisaHome
{
    public class UltimasPesquisaHomeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
