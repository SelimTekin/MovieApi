using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.UserLayoutWebUIViewComponents.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUIHeroComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
