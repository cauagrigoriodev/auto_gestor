using auto_gestor.Models; // Importa o namespace que contém o modelo de dados ClienteModel.
using Microsoft.EntityFrameworkCore; // Importa o namespace necessário para trabalhar com o Entity Framework Core.

namespace auto_gestor.Data // Define o namespace onde a classe BancoContext está localizada.
{
    public class BancoContext : DbContext // Define a classe BancoContext que herda de DbContext, permitindo a interação com o banco de dados.
    {
        // Construtor da classe BancoContext, que recebe as configurações do DbContext e as passa para a classe base DbContext.
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        // Define a propriedade DbSet<ClienteModel>, que representa a tabela de clientes no banco de dados.
        public DbSet<ClienteModel> ClienteModels { get; set; }
    }
}
