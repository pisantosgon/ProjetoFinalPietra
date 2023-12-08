using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{
    [Table("Procedimentorealizado")]
    public class Procedimentorealizado
    {
        [Column("Id")]
        [Display(Name = "Codigo do Procedimento")]
        public int Id { get; set; }



        [ForeignKey("ClienteId")]
        public int? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }



        [ForeignKey("ProcedimentoId")]
        public int? ProcedimentoId { get; set; }

        public Procedimento? Procedimento { get; set; }



        [ForeignKey("ColaboradorId")]
        public int? ColaboradorId { get; set; }

        public Colaborador? Colaborador { get; set; }



        [ForeignKey("LocalRealizacaoId")]
        public int? LocalrealizacaoId { get; set; }

        public Localrealizacao? Localrealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data da Realização")]
        public DateTime DataRealizacao { get; set; }


        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação")]
        public string ObservacaoRealizacao { get; set; }

    }
}
