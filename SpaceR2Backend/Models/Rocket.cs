namespace SpaceR2Backend.Models
{
    public class Rocket
    {
        public int Id { get; set; }
        public Configuration? Configuration { get; set; }
        public List<Launch> Launches { get; set; }
    }
}
