namespace gtorres.FluentIfThenElse
{
    public interface IFluentIf<T> where T : class
    {
        IFluentThen<T> If(bool @if);
    }
}
