namespace Wizkisoft.DotNet.FluentIfThenElse
{
    public class FluentIf<T> : IFluentIf<T> where T : class
    {
        public IFluentThen<T> If(bool @if) =>
            new FluentThen<T>(this as T, @if);
    }
}
