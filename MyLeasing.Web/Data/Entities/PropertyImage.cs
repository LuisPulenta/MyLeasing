using System.ComponentModel.DataAnnotations;
namespace MyLeasing.Web.Data.Entities
{
    public class PropertyImage
    {
        public int Id { get; set; }

        [Display(Name = "Foto")]
        public string ImageUrl { get; set; }

        public Property Property { get; set; }

        // TODO: Change the path when publish
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"http://keypress.serveftp.net:88/MyLeasing{ImageUrl.Substring(1)}";
    }
}