using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        [Inject]
        public ILogger<CounterBase> Logger { get; set; }

        protected void IncrementCount()
        {
            currentCount+=2;
            Logger.LogInformation("Counter {currentCount}", currentCount);
        }
    }
}
