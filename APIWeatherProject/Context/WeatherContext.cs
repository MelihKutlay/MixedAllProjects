using APIWeatherProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIWeatherProject.Context
{
    public class WeatherContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MELIH\\MELIH;initial catalog=DbAPIWeather; integrated Security = true");
        }
        public DbSet<City> Cities { get; set; }
    }
}