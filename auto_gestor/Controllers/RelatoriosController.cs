using Microsoft.AspNetCore.Mvc;

namespace auto_gestor.Controllers
{
    public class RelatoriosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
