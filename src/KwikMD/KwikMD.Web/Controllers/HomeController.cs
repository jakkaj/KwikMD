

using Microsoft.AspNetCore.Mvc;

namespace KwikMD.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Convert(string mdString)
        {
            //var md = new Markdown().Transform(mdString);
            var md = CommonMark.CommonMarkConverter.Convert(mdString);
            ViewData["converted"] = md;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
