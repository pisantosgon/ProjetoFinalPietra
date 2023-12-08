using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{
    [Table("Cidade")]
    public class Cidade
    {

        [Column("Id")]
        [Display(Name = "Codigo da cidade")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome da cidade")]
        public string CidadeNome { get; set; }

        [ForeignKey("Id")]
        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }


    }
}
