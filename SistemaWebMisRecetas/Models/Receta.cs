using SistemaWebMisRecetas.Validations;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Models
{
    public class Receta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [CategoriaValidation]
        public string Categoría { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [DataType(DataType.MultilineText)]
        public string Ingrediente { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [DataType(DataType.MultilineText)]
        public string Instruccion { get; set; }

        //Datos Autor

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50)]
        public string NombreAutor { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50)]
        public string ApellidoAutor { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [EdadAutorValidation]
        public int EdadAutor { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string EmailAutor { get; set; }
        
    }
}
