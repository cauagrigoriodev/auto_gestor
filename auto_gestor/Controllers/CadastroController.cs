using auto_gestor.Models;
using Microsoft.AspNetCore.Mvc;

namespace auto_gestor.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // CRIAÇÃO DAS PAGINAS DOS BOTÕES
        public IActionResult CriarCliente()
        {
            return View();
        }
        public IActionResult EditarCliente()
        {
            return View();
        }
        public IActionResult DeletarCliente()
        {
            return View();
        }
    }
}
