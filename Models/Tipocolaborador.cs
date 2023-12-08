using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{
    [Table("TipoColaborador")]
    public class Tipocolaborador
    {
        [Column("Id")]
        [Display(Name = "Codigo do Colaborador")]
        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Nome do Colaborador")]
        public string TipoColaboradorNome { get; set; }
    }
}
