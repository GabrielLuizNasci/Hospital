using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    [Table("Medicos")]
    public class Medico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Display(Name = "Especialidade: ")]
        public int EspecID { get; set; }

        [Display(Name = "Especialidade: ")]
        public Especialidade Especialidade { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "E-mail: ")]
        public string Email { get; set; }

        [Required]
        [StringLength(11)]
        [Display(Name = "Telefone: ")]
        public string Telefone { get; set; }

        [Display(Name = "Cidade: ")]
        public int CidadeID { get; set; }

        [Display(Name = "Cidade: ")]
        public Cidade Cidade { get; set; }
    }
}
