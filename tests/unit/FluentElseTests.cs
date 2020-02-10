using System;
using AutoFixture;
using FluentAssertions;
using Moq;
using Xunit;

namespace gtorres.FluentIfThenElse.Test.Unit
{
    public sealed class FluentElseTests
    {
        public class Foo { }

        public sealed class ElseShould
        {
            [Fact]
            public void ExecuteTheElseStatement_WhenTheIfExpressionEvaluatesToFalse()
            {
                var actionMock = new Mock<Action>();
                var @if = false;
                var @else = new FluentElse<Foo>(Mock.Of<Foo>(), @if);


                @else.Else(actionMock.Object);


                actionMock.Verify(m => m(), Times.Once);
            }

            [Fact]
            public void NotExecuteTheElseStatement_WhenTheIfExpressionEvaluatesToTrue()
            {
                var actionMock = new Mock<Action>();
                var @if = true;
                var @else = new FluentElse<Foo>(Mock.Of<Foo>(), @if);

                @else.Else(actionMock.Object);

                actionMock.Verify(m => m(), Times.Never);
            }

            [Fact]
            public void ReturnAFluentEndIfObject()
            {
                var fixture = new Fixture();
                var @else = fixture.Create<FluentElse<Foo>>();

                var result = @else.Else(Mock.Of<Action>());

                result.Should().BeOfType(typeof(FluentEndIf<Foo>), because: "This gives the caller a way back by calling this EndIf object.");
            }
        }

        public sealed class EndIfShould
        {
            [Fact]
            public void ReturnTheSameObjectThatOriginallyCalledIf()
            {
                var fixture = new Fixture();
                var @else = fixture.Create<FluentElse<Foo>>();

                var result = @else.EndIf();

                result.Should().BeOfType(typeof(Foo), because: "EndIf gets the caller back to the original object to call additional operations of that object.");
            }
        }
    }
}
