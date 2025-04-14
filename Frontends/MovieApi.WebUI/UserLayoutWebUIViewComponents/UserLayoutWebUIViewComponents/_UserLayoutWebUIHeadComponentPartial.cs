using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.UserLayoutWebUIViewComponents.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUIHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
