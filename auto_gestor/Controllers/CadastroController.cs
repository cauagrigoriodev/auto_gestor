using auto_gestor.Models; // Importa o namespace onde os modelos de dados (como ClienteModel) estão definidos.
using Microsoft.AspNetCore.Mvc; // Importa o namespace necessário para trabalhar com o ASP.NET Core MVC, incluindo a classe Controller.

namespace auto_gestor.Controllers // Define o namespace "auto_gestor.Controllers", onde o controlador "CadastroController" está localizado.
{
    public class CadastroController : Controller // Define a classe "CadastroController" que herda da classe base "Controller", fornecendo ações para manipulação de requisições HTTP.
    {
        // Ação responsável por exibir a página inicial de cadastros.
        public IActionResult Index()
        {
            return View(); // Retorna a view associada à ação "Index". Aqui seria a página principal do cadastro.
        }

        // Ação responsável por exibir a página para criar um novo cliente.
        public IActionResult CriarCliente()
        {
            return View(); // Retorna a view associada à ação "CriarCliente", onde o formulário para criar um novo cliente será exibido.
        }

        // Ação responsável por exibir a página para editar os dados de um cliente.
        public IActionResult EditarCliente()
        {
            return View(); // Retorna a view associada à ação "EditarCliente", onde o formulário para editar os dados de um cliente será exibido.
        }

        // Ação responsável por exibir a página para deletar um cliente.
        public IActionResult DeletarCliente()
        {
            return View(); // Retorna a view associada à ação "DeletarCliente", onde a confirmação para deletar o cliente será exibida.
        }
    }
}
