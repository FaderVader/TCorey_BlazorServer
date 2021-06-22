using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        public WeatherForecastService(IConfiguration config, ILogger<WeatherForecastService> logger)
        {
            _config = config;
            _logger = logger;
        }

        private readonly IConfiguration _config;
        private readonly ILogger _logger;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            int rangeTop = _config.GetValue<int>("WeatherForecast:Days");

            _logger.LogInformation($"RangeTop is {rangeTop}");

            return Task.FromResult(Enumerable.Range(1, rangeTop).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
