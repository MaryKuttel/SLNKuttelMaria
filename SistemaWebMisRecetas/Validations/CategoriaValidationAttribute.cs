using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CategoriaValidationAttribute : ValidationAttribute
    {
        public CategoriaValidationAttribute() 
        {
            ErrorMessage= "La categoría debe ser Desayuno";
        }

        public override bool IsValid(object value)
        {
            string categoria = (string)value;
            if (categoria.ToLower() == "desayuno")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
