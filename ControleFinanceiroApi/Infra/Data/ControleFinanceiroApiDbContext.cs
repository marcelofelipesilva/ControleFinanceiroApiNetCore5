using ControleFinanceiroApi.Business.Entities;
using ControleFinanceiroApi.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroApi.Infra.Data
{
    public class ControleFinanceiroApiDbContext : DbContext
    {
        
        public ControleFinanceiroApiDbContext(DbContextOptions<ControleFinanceiroApiDbContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContaPagarMapping());
            modelBuilder.ApplyConfiguration(new ReceitaMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
           
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=172.17.0.6;Database=ControleFinanceiroBD;User Id=sa;Password=App@12345;");
        }

        public DbSet<ContaPagar> ContasPagar { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}