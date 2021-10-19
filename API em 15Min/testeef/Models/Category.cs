using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }        

        [Required(ErrorMessage ="Este campo é obrigatorio")]        
        [MaxLength(100, ErrorMessage = "Este campo deve ter de 3 até 100 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter de 3 até 100 caracteres")]
        public string Title { get; set; }
    }
}
