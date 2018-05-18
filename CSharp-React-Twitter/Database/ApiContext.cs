using Microsoft.EntityFrameworkCore;
using CSharpReactTwitter.Models;

namespace CSharpReactTwitter.Database {
  public class ApiContext : DbContext {

    public ApiContext(DbContextOptions<ApiContext> options) : base(options) {
      
    }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Follow>().HasKey(fol => new { fol.FollowerId, fol.FollowingId });
			modelBuilder.Entity<User>()
						.HasMany(u => u.Followers)
						.WithOne(u => u.Following)
						.HasForeignKey(u => u.FollowingId);

			modelBuilder.Entity<User>()
						.HasMany(u => u.Following)
						.WithOne(u => u.Follower)
						.HasForeignKey(u => u.FollowerId);
    } 

    public DbSet<User> Users { get; set; }  
    public DbSet<Tweet> Tweets { get; set; }
		public DbSet<Follow> Follows { get; set; }
  }
}
