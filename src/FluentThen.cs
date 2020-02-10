using System;

namespace gtorres.FluentIfThenElse
{
    public sealed class FluentThen<T> : IFluentThen<T> where T : class
    {
        public FluentThen(T obj, bool @if)
        {
            _obj = obj;
            _if = @if;
        }

        public IFluentElse<T> Then(Action @then)
        {
            if (_if)
                @then();
            return new FluentElse<T>(_obj, _if);
        }

        private T _obj;

        private bool _if;
    }
}
