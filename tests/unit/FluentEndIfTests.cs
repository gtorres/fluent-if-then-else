using AutoFixture;
using FluentAssertions;
using Xunit;

namespace gtorres.FluentIfThenElse.Test.Unit
{
    public sealed class FluentEndIfTests
    {
        public class Foo { }

        public sealed class EndIfShould
        {
            [Fact]
            public void ReturnTheSameObjectThatOriginallyCalledIf()
            {
                var fixture = new Fixture();
                var @else = fixture.Create<FluentEndIf<Foo>>();

                var result = @else.EndIf();

                result.Should().BeOfType(typeof(Foo), because: "EndIf gets the caller back to the original object to call additional operations of that object.");
            }
        }
    }
}
