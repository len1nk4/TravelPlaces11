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
    }
}
