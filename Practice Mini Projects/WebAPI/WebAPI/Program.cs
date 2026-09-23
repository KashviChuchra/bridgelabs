using Repository.Interface;
using Repository.Service;
using BusinessLayer.Interface;
using BusinessLayer.Service;
namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddSingleton<IProductRL, ProductRL>();
            builder.Services.AddScoped<IProductBL, ProductBL>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
