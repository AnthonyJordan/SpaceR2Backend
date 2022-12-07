using System.ComponentModel.DataAnnotations;

namespace SpaceR2Backend.Models
{
    public class NasaPoDModel
    {
        [Key]
        public string? title { get; set; }
        public string? date { get; set; }
        public string? explanation { get; set; }
        public string? url { get; set; }
        public string? hdurl { get; set; }
        public string? copyright { get; set; }



    }
}
