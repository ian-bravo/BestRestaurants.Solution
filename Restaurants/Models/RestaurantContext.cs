using Microsoft.EntityFrameworkCore;

namespace Restaurants.Models
{
  public class RestaurantContext : DbContext
  {
    // public DbSet<Category> Categories { get; set; }
    // public DbSet<Item> Items { get; set; }

    public RestaurantContext(DbContextOptions options) : base(options) { }
  }
}