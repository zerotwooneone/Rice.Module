using System;

namespace Rice.Module.Abstractions.Execution
{
    public interface IServiceProvider
    {
        object Resolve(Type type);

        T Resolve<T>() => (T)Resolve(typeof(T));
    }
}