using System;

namespace gtorres.FluentIfThenElse
{
    public interface IFluentElse<T> : IFluentEndIf<T> where T : class
    {
        IFluentEndIf<T> Else(Action @else);
    }
}
