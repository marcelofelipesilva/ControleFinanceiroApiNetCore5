using ControleFinanceiroApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiroApi.Infra.Data.Mappings
{
    public class ContaPagarMapping : IEntityTypeConfiguration<ContaPagar>
    {
        public void Configure(EntityTypeBuilder<ContaPagar> builder)
        {
            builder.ToTable("TB_ContaPagar");
            builder.HasKey(p => p.ContaPagarID);
            builder.Property(p => p.ContaPagarID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.DataPagamento);
            builder.Property(p => p.Valor);
           
        }
    }
}