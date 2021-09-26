using ControleFinanceiroApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiroApi.Infra.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_Usuario");
            builder.HasKey(p => p.UsuarioID);
            builder.Property(p => p.UsuarioID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Login);
            builder.Property(p => p.Senha);
          
        }
        
    }
}