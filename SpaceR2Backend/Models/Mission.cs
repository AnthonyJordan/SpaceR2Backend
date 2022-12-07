namespace SpaceR2Backend.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Launch_designator { get; set; }
        public string? type { get; set; }
        public Orbit? Orbit { get; set; }
    }
}
