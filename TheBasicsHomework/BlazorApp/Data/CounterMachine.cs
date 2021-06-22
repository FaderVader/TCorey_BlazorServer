using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class CounterMachine : ICounterMachine
    {
        private int counterValue;

        public int CounterValue
        {
            get { return counterValue; }
        }

        public int Increment()
        {
            counterValue++;
            _logger.LogInformation($"CounterValue was changed. Current value is {CounterValue}");
            return counterValue;
        }

        public ILogger _logger { get; }

        public CounterMachine(ILogger<CounterMachine> logger)
        {
            _logger = logger;
            counterValue = 0;
        }
    }
}
