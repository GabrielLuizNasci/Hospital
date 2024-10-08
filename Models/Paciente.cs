using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

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

        [Key]
        public int CodPac { get; set; }

        [Required]
        public string NomePac { get; set; }

        [Required]
        public int CodCidad { get; set; }
        public int Status { get; set; }
    }
}
