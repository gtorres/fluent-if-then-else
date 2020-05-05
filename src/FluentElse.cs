using System;

namespace Wizkisoft.DotNet.FluentIfThenElse
{
    public sealed class FluentElse<T> : IFluentElse<T> where T : class
    {
        public FluentElse(T obj, bool @if)
        {
            _obj = obj;
            _if = @if;
        }

        public IFluentEndIf<T> Else(Action @else)
        {
            if (!_if)
                @else();
            return new FluentEndIf<T>(_obj);
        }

        public T EndIf() =>
            _obj;

        private T _obj;

        private bool _if;
    }
}
