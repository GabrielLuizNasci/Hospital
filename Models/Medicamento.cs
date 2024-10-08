using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Medicamento
    {
        [Key]
        public int CodMedica { get; set; }

        [Required]
        public string DescMedica { get; set; }

        public int QuantEstoque { get; set; }

        public int EstoqueMin { get; set; }

        public int EstoqueMax { get; set; }

        public float PrecUni { get; set; }
    }
}
