using auto_gestor.Models;
using Microsoft.AspNetCore.Mvc;

namespace auto_gestor.Controllers
{
    public class PagamentosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
