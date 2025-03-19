using System.Diagnostics;
using auto_gestor.Models;
using Microsoft.AspNetCore.Mvc;

namespace auto_gestor.Controllers
{
    public class HomeController : Controller
    {    

        public IActionResult Index()
        {
            // Estanciar a model
            Funcionario funcionario = new Funcionario();

            // Setar valores para a model
            funcionario.Name = "A*****";
            funcionario.Id = 1;


            return View(funcionario);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
