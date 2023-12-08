using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{

    [Table("Tipoprocedimento")]
    public class Tipoprocedimento
    {
        [Column("Id")]
        [Display(Name = "Codigo do Procedimento")]
        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Nome do Procedimento")]
        public string TipoProcedimentoNome { get; set; }


    }
}
