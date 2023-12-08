using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {

        [Column("Id")]
        [Display(Name = "Codigo do Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Nome do Procedimento")]
        public string ProcedimentoNome { get; set; }

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observacao do procedimento")]
        public string ProcedimentoObservacao { get; set; }


        [ForeignKey("Id")]
        public int TipoprocedimentoId { get; set; }

        public Tipoprocedimento? Tipoprocedimento { get; set; }
        

    }
}
