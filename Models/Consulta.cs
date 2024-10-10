using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    [Table("Consultas")]
    public class Consulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Display(Name = "Paciente: ")]
        public int PaciID { get; set; }

        [Display(Name = "Paciente: ")]
        public Paciente Paciente { get; set; }

        [Display(Name = "Médico: ")]
        public int MedicID { get; set; }

        [Display(Name = "Médico: ")]
        public Medico Medico { get; set; }

        [Required]
        [Display(Name = "Horário da Consulta: ")]
        public DateTime Horario { get; set; }

        [Display(Name = "Medicamento: ")]
        public int MedicamID { get; set; }

        [Display(Name = "Medicamento: ")]
        public Medicamento Medicamento { get; set; }

        [Required]
        [Display(Name = "Quantidade receitada: ")]
        public int QuantReceit { get; set; }
    }
}
