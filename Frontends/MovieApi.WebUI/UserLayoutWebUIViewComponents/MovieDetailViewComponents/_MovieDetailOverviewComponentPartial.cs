using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.UserLayoutWebUIViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailOverviewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
