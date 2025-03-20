using System.Diagnostics; // Importa o namespace necess�rio para usar a classe Activity (usada para rastrear o ID da requisi��o).
using auto_gestor.Models; // Importa o namespace onde o modelo "Funcionario" est� localizado.
using Microsoft.AspNetCore.Mvc; // Importa o namespace necess�rio para trabalhar com o ASP.NET Core MVC, incluindo a classe Controller.

namespace auto_gestor.Controllers // Define o namespace "auto_gestor.Controllers", onde o controlador "HomeController" est� localizado.
{
    public class HomeController : Controller // Define a classe "HomeController", que herda de "Controller" para gerenciar as requisi��es HTTP e retornar as Views.
    {

        // A��o que retorna a p�gina inicial (index).
        public IActionResult Index()
        {
            Funcionario funcionario = new Funcionario(); // Cria uma nova inst�ncia do objeto "Funcionario".

            funcionario.Name = "A*****"; // Define o nome do funcion�rio como "A*****".
            funcionario.Id = 1; // Define o ID do funcion�rio como 1.

            return View(funcionario); // Retorna a view associada � a��o "Index", passando o objeto "funcionario" para a view.
        }

        // A��o que exibe a p�gina de privacidade.
        public IActionResult Privacy()
        {
            return View(); // Retorna a view associada � a��o "Privacy", que mostra a pol�tica de privacidade.
        }

        // A��o que exibe a p�gina de erro, normalmente chamada quando ocorre algum problema durante a requisi��o.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // Configura o cache da resposta para n�o ser armazenado.
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); // Retorna a view de erro, passando o "RequestId" para identificar a requisi��o.
        }
    }
}
