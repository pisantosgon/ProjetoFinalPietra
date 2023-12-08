using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{
    [Table("Localrealizado")]
    public class Localrealizacao
    {

        [Column("Id")]
        [Display(Name = "Codigo de Realização")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Nome do Local")]
        public string LocalNome { get; set; }

        [ForeignKey("Id")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }


    }
}
