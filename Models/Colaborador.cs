using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Column("Id")]
        [Display(Name = "Codigo do Colaborador")]
        public int Id { get; set; }

        [Column("ColaboradorNome")]
        [Display(Name = "Nome do Colaborador")]
        public string ColaboradorNome { get; set; }

        [Column("ColaboradorCpf")]
        [Display(Name = "Cpf do Colaborador")]
        public string ColaboradorCpf { get; set; }

        [Column("ColaboradorSexo")]
        [Display(Name = "Sexo do Colaborador")]
        public string ClienteSexo { get; set; }

        [Column("ColaboradorTelefone")]
        [Display(Name = "Telefone do Colaborador")]
        public string ColaboradorTelefone { get; set; }

        [ForeignKey("Id")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

        [ForeignKey("Id")]
        public int TipocolaboradorId { get; set; }

        public Tipocolaborador? Tipocolaborador { get; set; }


    }
}
