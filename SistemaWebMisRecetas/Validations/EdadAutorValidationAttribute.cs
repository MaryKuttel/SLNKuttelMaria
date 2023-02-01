using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class EdadAutorValidationAttribute : ValidationAttribute
    {
        public EdadAutorValidationAttribute()
        {
            ErrorMessage = "La Edad del Autor debe ser Mayor o Igual a 18";
        }

        public override bool IsValid(object value)
        {
            int edad = (int)value;

            if (edad < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
