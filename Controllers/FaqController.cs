using Microsoft.AspNetCore.Mvc;

namespace FinalBackend.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
