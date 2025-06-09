using System.ComponentModel.DataAnnotations;
namespace FINALPROGRA3.Models
{
    public class Animal
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Especie { get; set; }
        [Required] 
        public int Edad { get; set; }
    }
}
