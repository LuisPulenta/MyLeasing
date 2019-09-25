using System;
using System.ComponentModel.DataAnnotations;
namespace MyLeasing.Web.Data.Entities
{
    public class Contract
    {
        public int Id { get; set; }

        [Display(Name = "Comentarios")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Remarks { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Fecha Inicio")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha Fin")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Activo?")]
        public bool IsActive { get; set; }

        public Property Property { get; set; }

        public Owner Owner { get; set; }

        public Lessee Lessee { get; set; }

        [Display(Name = "Fecha Inicio")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDateLocal => StartDate.ToLocalTime();

        [Display(Name = "Fecha Fin")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDateLocal => EndDate.ToLocalTime();
    }
}