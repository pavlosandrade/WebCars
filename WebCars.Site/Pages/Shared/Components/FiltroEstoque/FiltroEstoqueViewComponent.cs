using Microsoft.AspNetCore.Mvc;

namespace WebCars.Site.Pages.Shared.Components.FiltroEstoque
{
    public class FiltroEstoqueViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
