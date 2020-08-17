using Microsoft.EntityFrameworkCore;

namespace SecondDinoPark.Models
{
  public class SecondDinoParkContext : DbContext
  {
    public SecondDinoParkContext(DbContextOptions<SecondDinoParkContext> options) : base(options)
    {
    }
    public DbSet<Animal> Animals { get; set; }
  }
}