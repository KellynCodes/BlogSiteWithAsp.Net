using KellyBlog.DAL.Entities;
using KellyBlog.DAL.DbConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace KellyBlog.DAL.Seeds
{
    public class SeedData
    {



        public static async Task EnsurePopulatedAsync(IApplicationBuilder app)
        {
            BlogDbContext context = app.ApplicationServices.CreateScope().ServiceProvider
                .GetRequiredService<BlogDbContext>();

            if (!await context.Users.AnyAsync())
            {
                await context.Users.AddRangeAsync(UsersWithToDos());
                await context.SaveChangesAsync();
            }


        }


        private static User UsersWithToDos()
        {
            return new User()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "KellynCodes",
                Email = "kelly@gmail.com",
                Password = "kellyblog.com",
                Address = "Lagost State.",
                CreatedDated = DateTime.UtcNow,
            };
        }

    }
}
