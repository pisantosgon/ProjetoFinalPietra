using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{

    [Table("Estado")]
    public class Estado
    {

        [Column("Id")]
        [Display(Name = "Codigo do Estado")]
        public int Id { get; set; }


        [Column("EstadoNome")]
        [Display(Name = "Nome do Estado")]
        public string EstadoNome { get; set; }
    }
}
