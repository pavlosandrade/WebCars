using Microsoft.AspNetCore.Mvc;

namespace WebCars.Site.Pages.Shared.Components.Estoque
{
    public class EstoqueViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
