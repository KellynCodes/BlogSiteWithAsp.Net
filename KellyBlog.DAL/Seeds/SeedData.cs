using KellyBlog.DAL.Entities;
using KellyBlog.DAL.DbConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace TodoList.DAL.Seeds
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


        private static IEnumerable<User> UsersWithToDos()
        {
            return new List<User>()
            {
                new User()
                {
                    FirstName = "John Doe",
                    Email = "john.doe@domain.com",
                    Password = "123445678",
                    Address = "Enugu State.",
                    CreatedDated  = DateTime.UtcNow,
                },
            };
        }

    }
}
