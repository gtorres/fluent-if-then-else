using System;

namespace gtorres.FluentIfThenElse
{
    public interface IFluentThen<T> where T : class
    {
        IFluentElse<T> Then(Action then);
    }
}
