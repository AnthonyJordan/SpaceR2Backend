using Newtonsoft.Json;

namespace SpaceR2Backend.Models
{
    public class Launch_Service_Provider
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Url { get; set; }
        [JsonIgnore]
        public List<Launch> Launches { get; set; }
    }
}
