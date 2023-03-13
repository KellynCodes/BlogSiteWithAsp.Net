using Microsoft.EntityFrameworkCore;
using KellyBlog.DAL.Entities;
namespace KellyBlog.DAL.DbConfig
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            
        }

       public DbSet<User> Users { get; set; }
       public DbSet<Post> Posts { get; set; }
       public DbSet<Share> Shares { get; set; }
       public DbSet<Comment> Comments { get; set; }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }*/
    }
}
