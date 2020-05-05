namespace Wizkisoft.DotNet.FluentIfThenElse
{
    public interface IFluentEndIf<T> where T : class
    {
        T EndIf();
    }
}
