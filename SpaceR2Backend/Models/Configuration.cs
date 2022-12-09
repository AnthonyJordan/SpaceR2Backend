namespace SpaceR2Backend.Models
{
    //Rocket configuration. Not to be confused with other configs.
    public class Configuration
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Family { get; set; }
        public string? Full_name { get; set; }
        public string? Variant { get; set; }
        public List<Rocket> Rockets { get; set; }

    }
}
