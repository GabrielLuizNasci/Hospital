using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class EspecMedico
    {
        [Key]
        public int CodEspec { get; set; }

        [Required]
        public string DescEspec { get; set; }
    }
}
