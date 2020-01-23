using Rice.Module.Abstractions.Execution;

namespace Rice.Module.Abstractions
{
    public interface IModule
    {
        IExecutionResult Execute(IExecutionContext executionContext);
    }
}
