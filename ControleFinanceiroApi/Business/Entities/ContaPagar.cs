using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiroApi.Business.Entities
{
    public class ContaPagar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContaPagarID { get; set; }
        [StringLength(40)]
        public string Nome { get; set; }
        [StringLength(20)]
        public string DataPagamento { get; set; }
        public double Valor { get; set; }
    }
}