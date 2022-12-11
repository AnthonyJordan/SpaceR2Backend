using Newtonsoft.Json;

namespace SpaceR2Backend.Models
{
    public class Status
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Abbrev { get; set; }
        [JsonIgnore]
        public List<Launch> Launches { get; set; }
    }
}
