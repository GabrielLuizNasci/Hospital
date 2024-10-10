using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    [Table("Medicamentos")]
    public class Medicamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required]
        [StringLength(35)]
        [Display(Name = "Descrição: ")]
        public string DescMedica { get; set; }

        [Required]
        [Display(Name = "Estoque atual: ")]
        public int EstoqueMax { get; set; }

        [Required]
        [Display(Name = "Estoque atual: ")]
        public int QuantEstoque { get; set; }

        [Required]
        [Display(Name = "Estoque atual: ")]
        public int EstoqueMin { get; set; }

        [Required]
        [Display(Name = "Preço unitário: ")]
        public float PrecUni { get; set; }
    }
}
