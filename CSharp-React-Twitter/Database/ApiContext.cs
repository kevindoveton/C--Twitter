using Microsoft.EntityFrameworkCore;
using CSharpReactTwitter.Models;

namespace CSharpReactTwitter.Database {
  public class ApiContext : DbContext {

    public ApiContext(DbContextOptions<ApiContext> options) : base(options) {
      
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Tweet> Tweets { get; set; }

  }
}
