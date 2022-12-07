using System.ComponentModel.DataAnnotations;

namespace SpaceR2Backend.Models
{
    public class PersonModel
    {
        [Key]
        public string? Name { get; set; }
        public string? Craft { get; set; }
    }
}
