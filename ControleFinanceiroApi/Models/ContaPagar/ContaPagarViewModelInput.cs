using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroApi.Models.ContaPagar
{
    public class ContaPagarViewModelInput
    {
        [Required(ErrorMessage = "O campo Nome e obrigatorio. ")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Data de Pagamento e obrigatorio. ")]
        public string DataPagamento { get; set; }
        [Required(ErrorMessage = "O campo Valor e obrigatorio. ")]
        public double Valor { get; set; }
    }
}