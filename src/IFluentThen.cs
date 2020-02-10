using System;

namespace Wizkisoft.DotNet.FluentIfThenElse
{
    public interface IFluentThen<T> where T : class
    {
        IFluentElse<T> Then(Action then);
    }
}
