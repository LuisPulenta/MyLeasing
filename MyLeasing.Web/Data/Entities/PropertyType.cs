using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MyLeasing.Web.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo Propiedad")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}