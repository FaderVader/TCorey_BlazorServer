using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IDataAccess _db;

        public WeatherForecastService(IDataAccess db)
        {
            _db = db;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();

            int upperValue = _db.GetUserAge();
            return Task.FromResult(Enumerable.Range(1, upperValue).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
