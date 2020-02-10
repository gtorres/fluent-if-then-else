using System;

namespace gtorres.FluentIfThenElse
{
    public sealed class FluentElse<T> : IFluentElse<T> where T : class
    {
        public FluentElse(T obj, bool @if)
        {
            this.obj = obj;
            this.@if = @if;
        }

        public IFluentEndIf<T> Else(Action @else)
        {
            if (!@if)
                @else();
            return new FluentEndIf<T>(this.obj);
        }

        public T EndIf() =>
            this.obj;

        private T obj;

        private bool @if;
    }
}
