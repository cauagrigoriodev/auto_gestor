using auto_gestor.Models; // Importa o namespace onde os modelos de dados (como "Pagamento", caso seja necessário) estão definidos.
using Microsoft.AspNetCore.Mvc; // Importa o namespace necessário para trabalhar com o ASP.NET Core MVC, incluindo a classe Controller.

namespace auto_gestor.Controllers // Define o namespace "auto_gestor.Controllers", onde o controlador "PagamentosController" está localizado.
{
    public class PagamentosController : Controller // Define a classe "PagamentosController", que herda da classe base "Controller", fornecendo funcionalidades para manipulação de requisições HTTP.
    {
        // Ação que retorna a página inicial de pagamentos.
        public IActionResult Index()
        {
            return View(); // Retorna a view associada à ação "Index". Aqui, é a página principal para gerenciar os pagamentos.
        }
    }
}
