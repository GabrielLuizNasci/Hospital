using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Medico
    {
        [Key]
        public int CodMed { get; set; }

        [Required]
        public string NomeMed { get; set; }

        [Required]
        public int CodEspec { get; set; }

        [Required]
        public string EndMed { get; set; }

        [Required, StringLength(15)]
        public string Telefone { get; set; }

        [Required]
        public int CodCidad { get; set; }

        public int Status { get; set; }
    }
}
