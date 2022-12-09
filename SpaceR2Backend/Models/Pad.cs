namespace SpaceR2Backend.Models
{
    public class Pad
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Wiki_url { get; set; }
        public string? Map_url { get; set; }
        public string? Map_image { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set;}
        public Location? Location { get; set; }
        public List<Launch> Launches { get; set; }
    }
}
