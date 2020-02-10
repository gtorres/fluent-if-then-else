namespace gtorres.FluentIfThenElse
{
    public sealed class FluentEndIf<T> : IFluentEndIf<T> where T : class
    {
        public FluentEndIf(T obj) =>
            _obj = obj;

        public T EndIf() =>
            _obj;

        private T _obj;
    }
}
