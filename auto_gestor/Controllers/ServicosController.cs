using Microsoft.AspNetCore.Mvc;

namespace auto_gestor.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
