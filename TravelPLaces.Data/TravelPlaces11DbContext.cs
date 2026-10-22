using TravelPLaces11.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace TravelPLaces11.Data
{
    public class TravelPlaces11DbContext : DbContext
    {
        public TravelPlaces11DbContext(DbContextOptions<TravelPlaces11DbContext> options) : base(options)
        {
        }

        public DbSet<TravelPlace> TravelPlaces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TravelPlace>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(e => e.Area)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(e => e.Type)
                .IsRequired();

                entity.Property(e => e.Fee)
                .HasColumnType("decimal(18,2)");

                entity.Property(e => e.Description)
                .HasMaxLength(1000);

            });

        }
    }
}
