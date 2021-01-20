using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public TravelApiContext(DbContextOptions<TravelApiContext> options)
      : base(options)
      {
      }

    public DbSet<Destination> Destinations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
          .HasData(
              new Destination { DestinationId = 1, CityName = "Bali", Country = "Indonesia", Review = "The best place I've ever been!", Rating = 5 },
              new Destination { DestinationId = 2, CityName = "Austin, TX", Country = "United States", Review = "Great restaurants and shopping.", Rating = 4 },
              new Destination { DestinationId = 3, CityName = "San Francisco, CA", Country = "United States", Review = "Such a great city!", Rating = 5 },
              new Destination { DestinationId = 4, CityName = "Seoul", Country = "South Korea", Review = "We had the time of our lives here.", Rating = 5 },
              new Destination { DestinationId = 5, CityName = "Portland, OR", Country = "United States", Review = "Beautiful, but wet.", Rating = 5 }
          );
    }
  }
}