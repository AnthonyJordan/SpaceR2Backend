using Microsoft.EntityFrameworkCore;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.database
{
    public class Context : DbContext
    {
        public DbSet<NasaPoDModel> NasaPoD { get; set; }
        public DbSet<PersonModel> People { get; set; }
        public DbSet<Launch> Launches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlite("Data Source = database/SpaceR2.db"); 
        }
    }
}
