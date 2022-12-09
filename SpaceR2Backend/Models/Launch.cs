using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaceR2Backend.Models
{
    public class Launch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DBID { get; set; }
        public string Id { get; set; }
        public string? Url { get; set; }
        public string? Name { get; set; }
        public Status? Status { get; set; }
        public string? Last_updated { get; set; }
        public string? Window_start { get; set; }
        public string? Window_end { get; set; }
        public LaunchServiceProvider? LaunchServiceProvider { get; set; }
        public Rocket? Rocket { get; set; }
        public Mission? Mission { get; set; }
        public Pad? Pad { get; set; }
        public string? Image { get; set;  }

    }
}
