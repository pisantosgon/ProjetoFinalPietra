using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalPietra.Models
{
    [Table("Cliente")]
    public class Cliente
    {

        [Column("Id")]
        [Display(Name = "Codigo do Cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; }

        [Column("ClienteCpf")]
        [Display(Name = "Cpf do Cliente")]
        public string ClienteCpf { get; set; }

        [Column("ClienteSexo")]
        [Display(Name = "Sexo do Cliente")]
        public string ClienteSexo { get; set; }

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone do Cliente")]
        public string ClienteTelefone { get; set; }


        [Column("ClienteEndereco")]
        [Display(Name = "Endereco do Cliente")]
        public string ClienteEndereco { get; set; }


        [Column("ClienteNumero")]
        [Display(Name = "Numero do Cliente")]
        public string ClienteNumero { get; set; }

        [ForeignKey("Id")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

    }
}
