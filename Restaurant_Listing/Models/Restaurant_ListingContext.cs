using Microsoft.EntityFrameworkCore;

namespace Restaurant_Listing.Models
{
  public class Restaurant_ListingContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Cuisine> Cuisines { get; set; }

    public Restaurant_ListingContext(DbContextOptions options) : base(options) { }
  }
}