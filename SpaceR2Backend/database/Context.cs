using Microsoft.EntityFrameworkCore;
using SpaceR2Backend.Models;

namespace SpaceR2Backend.database
{
    public class Context : DbContext
    {
        public DbSet<NasaPoDModel> NasaPoD { get; set; }
        public DbSet<PersonModel> People { get; set; }
        public DbSet<Launch> Launches { get; set; }
        public DbSet<Status> Statuses{ get; set; }
        public DbSet<Pad> Pads { get; set; }
        public DbSet<Rocket> Rockets { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Launch_Service_Provider> Launch_Service_Providers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Orbit> Orbits { get; set; }
        public DbSet<Mission> Missions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlite("Data Source = SpaceR2.db"); 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("PD");

            builder.Entity<Launch>()
              .HasOne(s => s.Status)
              .WithMany(l => l.Launches)
              .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Launch>()
              .HasOne(lsp => lsp.Launch_Service_Provider)
              .WithMany(l => l.Launches)
              .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Launch>()
              .HasOne(r => r.Rocket)
              .WithMany(l => l.Launches)
              .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Launch>()
              .HasOne(m => m.Mission)
              .WithMany(l => l.Launches)
              .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Launch>()
              .HasOne(p => p.Pad)
              .WithMany(l => l.Launches)
              .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Pad>()
              .HasOne(l => l.Location)
              .WithMany(p => p.Pads)
              .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Rocket>()
              .HasOne(c => c.Configuration)
              .WithMany(r => r.Rockets)
              .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
