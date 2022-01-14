using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
  public class PierresTreatsContext : IdentityDbContext<ApplicationUser>
  {
    DbSet<Flavor> Flavors { get; set; }
    DbSet<Treat> Treats { get; set; }
    DbSet<FlavorTreat> FlavorTreat { get; set; }
    public PierresTreatsContext(DbContextOptions options) : base(options){}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}