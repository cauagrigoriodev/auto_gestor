using Microsoft.AspNetCore.Mvc; // Importa o namespace necessário para trabalhar com o ASP.NET Core MVC, incluindo a classe Controller.

namespace auto_gestor.Controllers // Define o namespace "auto_gestor.Controllers", onde o controlador "RelatoriosController" está localizado.
{
    public class RelatoriosController : Controller // Define a classe "RelatoriosController", que herda da classe base "Controller", para manipular requisições HTTP e retornar views.
    {
        // Ação responsável por exibir a página principal dos relatórios.
        public IActionResult Index()
        {
            return View(); // Retorna a view associada à ação "Index", que exibe a página principal dos relatórios.
        }
    }
}
