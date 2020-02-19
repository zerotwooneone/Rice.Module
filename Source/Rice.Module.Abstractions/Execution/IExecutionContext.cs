namespace Rice.Module.Abstractions.Execution
{
    public interface IExecutionContext
    {
        IServiceProvider ServiceProvider { get; }
    }
}