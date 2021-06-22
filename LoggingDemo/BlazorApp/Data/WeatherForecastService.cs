using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        public WeatherForecastService(ILogger<WeatherForecastService> logger)
        {
            log = logger;
        }

        private readonly ILogger log;

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            log.LogInformation("Now generating weatherForecast");

            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
