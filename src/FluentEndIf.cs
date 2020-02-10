namespace gtorres.FluentIfThenElse
{
    public sealed class FluentEndIf<T> : IFluentEndIf<T> where T : class
    {
        public FluentEndIf(T obj) =>
            this.obj = obj;

        public T EndIf() =>
            this.obj;

        private T obj;
    }
}
