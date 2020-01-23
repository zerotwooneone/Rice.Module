using Rice.Module.Abstractions;
using Rice.Module.Abstractions.Execution;
using Rice.Module.Execution;

namespace TestModule
{
    public class Class1 : IModule
    {
        public IExecutionResult Execute(IExecutionContext executionContext)
        {
            return executionContext.CreateExecutionResult();
        }
    }
}
