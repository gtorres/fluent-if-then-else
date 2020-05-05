namespace Wizkisoft.DotNet.FluentIfThenElse
{
    public interface IFluentIf<T> where T : class
    {
        IFluentThen<T> If(bool @if);
    }
}
