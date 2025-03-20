using System.Diagnostics; // Importa o namespace necessário para usar a classe Activity (usada para rastrear o ID da requisição).
using auto_gestor.Models; // Importa o namespace onde o modelo "Funcionario" está localizado.
using Microsoft.AspNetCore.Mvc; // Importa o namespace necessário para trabalhar com o ASP.NET Core MVC, incluindo a classe Controller.

namespace auto_gestor.Controllers // Define o namespace "auto_gestor.Controllers", onde o controlador "HomeController" está localizado.
{
    public class HomeController : Controller // Define a classe "HomeController", que herda de "Controller" para gerenciar as requisições HTTP e retornar as Views.
    {

        // Ação que retorna a página inicial (index).
        public IActionResult Index()
        {
            Funcionario funcionario = new Funcionario(); // Cria uma nova instância do objeto "Funcionario".

            funcionario.Name = "A*****"; // Define o nome do funcionário como "A*****".
            funcionario.Id = 1; // Define o ID do funcionário como 1.

            return View(funcionario); // Retorna a view associada à ação "Index", passando o objeto "funcionario" para a view.
        }

        // Ação que exibe a página de privacidade.
        public IActionResult Privacy()
        {
            return View(); // Retorna a view associada à ação "Privacy", que mostra a política de privacidade.
        }

        // Ação que exibe a página de erro, normalmente chamada quando ocorre algum problema durante a requisição.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // Configura o cache da resposta para não ser armazenado.
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); // Retorna a view de erro, passando o "RequestId" para identificar a requisição.
        }
    }
}
