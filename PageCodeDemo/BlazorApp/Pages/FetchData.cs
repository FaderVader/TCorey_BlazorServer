using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] forecasts;

        [Inject]
        private WeatherForecastService ForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
