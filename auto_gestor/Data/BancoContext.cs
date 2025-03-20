using auto_gestor.Models;
using Microsoft.EntityFrameworkCore;

namespace auto_gestor.Data
{
    public class BancoContext : DbContext
    {
        // configuração do construtor com o DbOptions como parâmetro de entrada.
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ClienteModel> ClienteModels { get; set; }
    }
}
