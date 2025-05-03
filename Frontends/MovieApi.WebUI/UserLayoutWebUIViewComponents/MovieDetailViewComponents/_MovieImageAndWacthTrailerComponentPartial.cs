using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.UserLayoutWebUIViewComponents.MovieDetailViewComponents
{
    public class _MovieImageAndWacthTrailerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
