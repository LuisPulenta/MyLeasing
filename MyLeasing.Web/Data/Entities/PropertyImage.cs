using System.ComponentModel.DataAnnotations;
namespace MyLeasing.Web.Data.Entities
{
    public class PropertyImage
    {
        public int Id { get; set; }

        [Display(Name = "Foto")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string ImageUrl { get; set; }

        public Property Property { get; set; }

        // TODO: Change the path when publish
        public string ImageFullPath => $"http://keypress.serveftp.net:88/MyLeasingApi{ImageUrl.Substring(1)}";
    }
}