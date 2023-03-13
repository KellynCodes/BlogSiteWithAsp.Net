using KellyBlog.BLL.Implementations;
using KellyBlog.BLL.Interfaces;
using KellyBlog.DAL.DbConfig;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TodoList.DAL.Repository;

namespace KellyBlog
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BlogDbContext
                >(dbOption =>
            {
                var ConnectionString = builder.Configuration.GetSection("ConnectionStrings")["ConnString"];
                dbOption.UseSqlServer(ConnectionString);
            });

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork<BlogDbContext>>();
            builder.Services.AddScoped<IPostServices, PostServices>();
            builder.Services.AddScoped<ICommentServices, CommentServices>();
            builder.Services.AddAutoMapper(Assembly.Load("KellyBlog.BLL"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            await SeedData.EnsurePopulatedAsync(app);
            await app.RunAsync();
        }
    }
}