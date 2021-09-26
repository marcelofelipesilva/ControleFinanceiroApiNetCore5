using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroApi.Models.Usuario
{
    public class UsuarioViewModelInput
    {  
        [Required(ErrorMessage = "o campo Nome é obrigatorio.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "o campo Login é obrigatorio.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "o campo Senha é obrigatorio.")]
        public string Senha { get; set; }
        
    }
}