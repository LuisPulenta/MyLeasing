using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MyLeasing.Web.Data.Entities
{
    public class Property
    {
        public int Id { get; set; }

        [Display(Name = "Barrio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Neighborhood { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Address { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Metros Cuadrados")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int SquareMeters { get; set; }

        [Display(Name = "Habitaciones")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Rooms { get; set; }

        [Display(Name = "Estrato")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int Stratum { get; set; }

        [Display(Name = "Estacionamiento?")]
        public bool HasParkingLot { get; set; }

        [Display(Name = "Disponible?")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        public PropertyType PropertyType { get; set; }

        public Owner Owner { get; set; }
        public ICollection<PropertyImage> PropertyImages { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}