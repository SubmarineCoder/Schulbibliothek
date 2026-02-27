using Microsoft.EntityFrameworkCore;
using Schulbibliothek.Data;
using Schulbibliothek.Logic;
using Schulbibliothek.Models.Interfaces;

namespace Schulbibliothek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var sqlServerInstanceName = Environment.GetEnvironmentVariable("SqlServerInstanceName", EnvironmentVariableTarget.User);
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<SchulbibliothekDbContext>(options => 
            options.UseSqlServer($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Schulbibliothek;Data Source={sqlServerInstanceName};TrustServerCertificate=true"));

            builder.Services.AddScoped<IMapper, Mapper>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
