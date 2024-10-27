using Microsoft.AspNetCore.Mvc;

namespace Desafio_3_DSP.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
