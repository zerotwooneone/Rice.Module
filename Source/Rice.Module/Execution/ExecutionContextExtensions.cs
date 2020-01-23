using Rice.Module.Abstractions.Execution;

namespace Rice.Module.Execution
{
    public static class ExecutionContextExtensions
    {
        public static IExecutionResult CreateExecutionResult(this IExecutionContext executionContext)
        {
            return new ExecutionResult();
        }
    }
}
