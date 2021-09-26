using ControleFinanceiroApi.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ControleFinanceiroApi.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<ControleFinanceiroApiDbContext>
    {
        public ControleFinanceiroApiDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ControleFinanceiroApiDbContext>();
            ControleFinanceiroApiDbContext contexto = new ControleFinanceiroApiDbContext(optionsBuilder.Options);
            return contexto;
        }
    }
}