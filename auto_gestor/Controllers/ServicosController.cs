using Microsoft.AspNetCore.Mvc; // Importa o namespace necessário para trabalhar com o ASP.NET Core MVC, incluindo a classe Controller.

namespace auto_gestor.Controllers // Define o namespace "auto_gestor.Controllers", onde o controlador "ServicosController" está localizado.
{
    public class ServicosController : Controller // Define a classe "ServicosController", que herda da classe base "Controller", responsável por manipular requisições HTTP e retornar Views.
    {
        // Ação responsável por exibir a página inicial de serviços.
        public IActionResult Index()
        {
            return View(); // Retorna a view associada à ação "Index", que exibe a página principal dos serviços.
        }
    }
}
