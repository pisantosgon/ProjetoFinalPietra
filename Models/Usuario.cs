using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{
    [Table("Usuario")]
    public class Usuario
    {

        [Column("Id")]
        [Display(Name = "Codigo do Usuario")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome de Usuario")]
        public string UsuarioNome { get; set; }

        [Column("UsuarioEmail")]
        [Display(Name = "Email do Usuario")]
        public string UsuarioEmail { get; set; }

        [Column("UsuarioSenha")]
        [Display(Name = "Senha do Usuario")]
        public string UsuarioSenha { get; set; }

    }
}
