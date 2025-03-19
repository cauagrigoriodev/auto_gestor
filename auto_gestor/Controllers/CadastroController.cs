using auto_gestor.Models;
using Microsoft.AspNetCore.Mvc;

namespace auto_gestor.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            Cliente cliente = new Cliente();

            cliente.Id = 2;
            cliente.Name = "Julio";
            cliente.Cpf = "123.864.957-43";
            cliente.Data_Nasc = new DateTime(1993, 03, 25);
            cliente.Endereco = "julio@gmail.com";
            cliente.Telefone = "(85)99633644";
            cliente.Categoria = "A";

            return View(cliente);
        }
    }
}
