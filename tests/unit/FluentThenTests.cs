using System;
using AutoFixture;
using FluentAssertions;
using Moq;
using Xunit;

namespace Wizkisoft.DotNet.FluentIfThenElse.Test.Unit
{
    public sealed class FluentThenTests
    {
        public sealed class ThenShould
        {
            public class Foo { }

            [Fact]
            public void ExecuteTheThenStatement_WhenTheIfExpressionEvaluatesToTrue()
            {
                var fixture = new Fixture();

                var actionMock = new Mock<Action>();
                var @if = true;
                var @then = new FluentThen<Foo>(Mock.Of<Foo>(), @if);


                @then.Then(actionMock.Object);


                actionMock.Verify(m => m(), Times.Once);
            }

            [Fact]
            public void NotExecuteTheThenStatement_WhenTheIfExpressionEvaluatesToFalse()
            {
                var fixture = new Fixture();

                var actionMock = new Mock<Action>();
                var @if = false;
                var @then = new FluentThen<Foo>(Mock.Of<Foo>(), @if);


                @then.Then(actionMock.Object);


                actionMock.Verify(m => m(), Times.Never);
            }

            [Fact]
            public void ReturnAFluentElseObject()
            {
                var fixture = new Fixture();
                var @then = fixture.Create<FluentThen<Foo>>();

                var result = @then.Then(Mock.Of<Action>());

                result.Should().BeOfType(typeof(FluentElse<Foo>), because: "The caller can subsequently provide an else statement or end the statement from the else object.");
            }
        }
    }
}
