using auto_gestor.Models;
using Microsoft.AspNetCore.Mvc;

namespace auto_gestor.Controllers
{
    public class PagamentosController : Controller
    {
        public IActionResult Index()
        {
            Pagamentos pagamentos = new Pagamentos();

            pagamentos.Id = 1;
            pagamentos.Metodo_Pagamento = "Cartão de Crédito";
            pagamentos.Data_Inicio = new DateTime(2025 / 03 / 25);
            pagamentos.Data_Vencimento = new DateTime(2025 / 06 / 25);
            pagamentos.Status = "Em andamento";

            return View(pagamentos);
        }
    }
}
