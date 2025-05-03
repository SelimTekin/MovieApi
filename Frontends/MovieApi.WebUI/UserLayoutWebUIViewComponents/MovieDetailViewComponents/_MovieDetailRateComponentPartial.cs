using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.UserLayoutWebUIViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailRateComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
