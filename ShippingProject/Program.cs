
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShippingProject.Models;
using ShippingProject.Reposaitory;
using Microsoft.Extensions.DependencyInjection;
using ShippingProject.Data;
using System.Web.Http.Cors;
using static System.Net.Mime.MediaTypeNames;

namespace ShippingProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt = "hi";

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ShippingProjectContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ShippingProjectContext") ?? throw new InvalidOperationException("Connection string 'ShippingProjectContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<GovernatesReposaitory>();
            builder.Services.AddScoped< CitiesReposaitory>();
            builder.Services.AddScoped< BranchesRepo>();
            builder.Services.AddScoped<ITraderRepository, TraderRepository>();
            builder.Services.AddScoped<ISpecialPriceRepository, SpecialPriceRepository>();




            builder.Services.AddDbContext<ShippingContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectDB"));
            });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(txt,
                builder =>
                {
                    builder.AllowAnyOrigin();
                    //                    builder.WithOrigins('','')
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.UseCors(txt);

            app.MapControllers();

            app.Run();
        }
    }
}