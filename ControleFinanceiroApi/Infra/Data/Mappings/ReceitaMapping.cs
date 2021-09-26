using ControleFinanceiroApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiroApi.Infra.Data.Mappings
{
    public class ReceitaMapping : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.ToTable("TB_Receita");
            builder.HasKey(p => p.ReceitaID);
            builder.Property(p => p.ReceitaID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.DataRecebimento);
            builder.Property(p => p.Valor);
           
        }
    }
}