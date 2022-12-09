namespace SpaceR2Backend.Models
{
    public class Orbit
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Abbrev { get; set; }
        public List<Mission> Missions { get; set; }
    }
}
