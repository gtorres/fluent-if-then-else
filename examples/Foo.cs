namespace Wizkisoft.DotNet.FluentIfThenElse.Example
{
    public class Foo : IFluentIf<Foo>
    {
        public IFluentThen<Foo> If(bool @if) =>
            new FluentThen<Foo>(this, @if);
    }
}
