
using Microsoft.EntityFrameworkCore;
using Services.People.Domains;
using Services.People.Domains.Interfaces;
using Services.People.Infrastructure;
using Services.People.Infrastructure.Context;
using Services.People.Infrastructure.Interfaces;
using System.Text.Json.Serialization;

namespace Services.People.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("People"));

            // Add services to the container.
            builder.Services.AddScoped<IPeopleDomain, PeopleDomain>();

            builder.Services.AddScoped<IPeopleContext, PeopleContext>();

            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
