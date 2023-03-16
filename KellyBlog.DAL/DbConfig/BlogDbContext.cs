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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(prop => prop.Email, $"IX_{nameof(User.Email)}").IsUnique(true);
                entity.Property(p => p.LastName).IsRequired(false);
                entity.Property(p => p.Address).IsRequired(false);
                entity.Property(p => p.PostId).IsRequired(false);
                 entity.Property(p => p.Concurrency).IsRequired(false);
                entity.Property(p => p.UpdatedDated).IsRequired(false);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(prop => prop.UserId, $"IX_{nameof(Post.UserId)}").IsUnique(true);
                entity.Property(p => p.CommentsId).IsRequired(false);
                entity.Property(p => p.ShareId).IsRequired(false);
                entity.Property(p => p.Likes).IsRequired(false);
                 entity.Property(p => p.Concurrency).IsRequired(false);
                entity.Property(p => p.UpdatedDated).IsRequired(false);
            });

            modelBuilder.Entity<Share>(entity =>
            {
                entity.HasIndex(prop => prop.UserId, $"IX_{nameof(Share.UserId)}").IsUnique(true);
                entity.Property(p => p.Shares).IsRequired(false);
                 entity.Property(p => p.Concurrency).IsRequired(false);
                entity.Property(p => p.UpdatedDated).IsRequired(false);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasIndex(prop => prop.UserId, $"IX_{nameof(Comment.UserId)}").IsUnique(true);
                entity.Property(p => p.Likes).IsRequired(false);
                entity.Property(p => p.Replies).IsRequired(false);
                 entity.Property(p => p.Concurrency).IsRequired(false);
                entity.Property(p => p.UpdatedDated).IsRequired(false);
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
