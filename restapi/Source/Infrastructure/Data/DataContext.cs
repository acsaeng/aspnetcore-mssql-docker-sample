using Microsoft.EntityFrameworkCore;
using Sample.Core.Entities;

namespace Sample.Infrastructure.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}

    public DbSet<Person> People { get; set; }
  }
}