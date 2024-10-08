using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    [Table("Cidades")]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="ID: ")]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Estado: ")]
        public string Estado { get; set; }

        [Key]
        public int CodCidad { get; set; }

        [Required, StringLength(30)]
        public string NomeCid { get; set; }

        [Required, StringLength(4)]
        public string UF { get; set; }
        
        [Key]
        public int CodCid { get; set; }

        [Required]
        public string DescCid { get; set; }
    }
}
