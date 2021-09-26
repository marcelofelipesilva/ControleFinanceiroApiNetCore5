using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiroApi.Business.Entities
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(10)]
        public string Logina { get; set; }
        [StringLength(8)]
        public string Senha { get; set; }
    }
}