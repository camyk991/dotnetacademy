using System.Diagnostics;
using IsNewsPropaganda.Data;
using IsNewsPropaganda.RouteConstraints;
using IsNewsPropaganda.Services.Abstractions;
using IsNewsPropaganda.Services.Implementation;
using Microsoft.EntityFrameworkCore;

namespace IsNewsPropaganda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<IsNewsPropagandaDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            // builder.Services.AddRouting(opt => opt.ConstraintMap.Add("positiveInt", typeof(PositiveIntConstraint)));
            
            
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IArticleService, ArticleService>();
            
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
            
            // Add routing middleware
            app.UseRouting();

            app.UseAuthorization();
            
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }
    }
}