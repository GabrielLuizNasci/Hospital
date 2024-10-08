using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Consulta
    {
        [Key]
        public int CodConsu { get; set; }

        [Required]
        public int CodPac { get; set; }

        [Required]
        public int CodMed { get; set; }

        [Required]
        public string Data { get; set; }

        [Required]
        public string Horario { get; set; }

        [Required]
        public int CodCid { get; set; }

        [Required]
        public int CodMedica { get; set; }

        public int QuantEstoque { get; set; }
    }
}
