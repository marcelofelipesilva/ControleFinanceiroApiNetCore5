using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiroApi.Business.Entities
{
    public class Receita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaID  { get; set; }
        [StringLength(40)]
        public string Nome { get; set; }
        [StringLength(20)]
        public string DataRecebimento { get; set; }
        public double Valor { get; set; }   
    }
}