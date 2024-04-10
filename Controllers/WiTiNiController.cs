using Microsoft.AspNetCore.Mvc;

namespace WiTiNi.Controllers
{
    public class WiTiNiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
