namespace SpaceR2Backend.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? country_code { get; set; }
        public string? map_image { get; set; }

        public List<Pad> Pads { get; set; }
    }
}
