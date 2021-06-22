namespace BlazorApp.Data
{
    public interface ICounterMachine
    {
        int CounterValue { get; }

        int Increment();
    }
}