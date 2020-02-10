using System;

namespace Wizkisoft.DotNet.FluentIfThenElse
{
    public interface IFluentElse<T> : IFluentEndIf<T> where T : class
    {
        IFluentEndIf<T> Else(Action @else);
    }
}
