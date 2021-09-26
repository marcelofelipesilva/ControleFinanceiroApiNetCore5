using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroApi.Models.Receita
{
    public class ReceitaViewModelInput
    {   
        [Required(ErrorMessage = "o campo Nome é obrigatorio.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "o campo Data de Recebimento é obrigatorio.")]
        public string DataRecebimento { get; set; }
        [Required(ErrorMessage = "o campo Valor é obrigatorio.")]
        public double Valor { get; set; }   
    }
    
}