using System;

namespace gtorres.FluentIfThenElse
{
    public sealed class FluentThen<T> : IFluentThen<T> where T : class
    {
        public FluentThen(T obj, bool @if)
        {
            this.obj = obj;
            this.@if = @if;
        }

        public IFluentElse<T> Then(Action @then)
        {
            if (@if)
                @then();
            return new FluentElse<T>(this.obj, @if);
        }

        private T obj;

        private bool @if;
    }
}
