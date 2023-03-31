using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public ParksApiContext(DbContextOptions<ParksApiContext> options) : base(options)
    {
    }

    protected override void
    OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>().HasData(
        new Park { ParkId = 1, Name = "Crater Lake National Park", Location = "Oregon", Review = "Great", Rating = 10 },
        new Park { ParkId = 2, Name = "Olympic National Park", Location = "Washington", Review = "Excellent", Rating = 8 },
        new Park { ParkId = 3, Name = "San Juan Island National Historic Park", Location = "Washington", Review = "Very Good", Rating = 7},
        new Park { ParkId = 4, Name = "Everglades National Park", Location = "Florida", Review = "Awesome, but hot", Rating = 8},
        new Park { ParkId = 5, Name = "Dead Horse Point State Park", Location = "Utah", Review = "Nice", Rating = 8},
        new Park { ParkId = 6, Name = "Chugach State Park", Location = "Alaska", Review = "Pretty", Rating = 6},
        new Park { ParkId = 7, Name = "Canaveral National Seashore", Location = "Florida", Review = "Pretty", Rating = 6},
        new Park { ParkId = 8, Name = "Valley of Fire State Park", Location = "Nevada", Review = "Gorgeous, but warm during the day and cold at night", Rating = 8},
        new Park { ParkId = 9, Name = "Voyageurs National Park", Location = "Minnesota", Review = "Remote and low average visitor count", Rating = 6},
        new Park { ParkId = 10, Name = "Bryce Canyon National Park", Location = "Utah", Review = "Too orange, too spiky", Rating = 1},
        new Park { ParkId = 11, Name = "Haleakalā National Park", Location = "Hawaii", Review = "Perfect", Rating = 10},
        new Park { ParkId = 12, Name = "Yellowstone National Park", Location = "Wyoming", Review = "Great geyser!", Rating = 9},
        new Park { ParkId = 13, Name = "Saguaro National Park", Location = "Arizona", Review = "Lots of cacti!", Rating = 8},
        new Park { ParkId = 14, Name = "Great Smoky Mountains National Park", Location = "Tennessee", Review = "Nothing specific to do", Rating = 2}
      );
    }
  }
}