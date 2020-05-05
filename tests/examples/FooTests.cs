using System;
using AutoFixture;
using FluentAssertions;
using Moq;
using Xunit;

namespace Wizkisoft.DotNet.FluentIfThenElse.Example.Test
{
    public sealed class FooTests
    {
        public sealed class IfShould
        {
            [Fact]
            public void ExecuteActionProvidedToThen_WhenIfExpressionEvaluatesToTrue()
            {
                var fixture = new Fixture();
                var thenActionMock = new Mock<Action>();
                var elseActionMock = new Mock<Action>();
                var @if = true;

                var foo = fixture.Create<Foo>();


                foo.If(@if)
                .Then(thenActionMock.Object)
                .Else(elseActionMock.Object);


                thenActionMock.Verify(m => m(), Times.Once);
                elseActionMock.Verify(m => m(), Times.Never);
            }

            [Fact]
            public void ExecuteActionProvidedToElse_WhenIfExpressionEvaluatesToFalse()
            {
                var fixture = new Fixture();
                var thenActionMock = new Mock<Action>();
                var elseActionMock = new Mock<Action>();
                var @if = false;

                var foo = fixture.Create<Foo>();


                foo.If(@if)
                .Then(thenActionMock.Object)
                .Else(elseActionMock.Object);


                thenActionMock.Verify(m => m(), Times.Never);
                elseActionMock.Verify(m => m(), Times.Once);
            }

            [Fact]
            public void HaveChainableEndIfFromThen()
            {
                var fixture = new Fixture();
                var foo = fixture.Create<Foo>();

                var result = foo.If(fixture.Create<bool>())
                .Then(Mock.Of<Action>())
                .EndIf();

                result.Should().BeOfType(typeof(Foo), because: "The caller needs to have a way to get back to the original object.");
            }

            [Fact]
            public void HaveChainableEndIfFromElse()
            {
                var fixture = new Fixture();
                var foo = fixture.Create<Foo>();

                var result = foo.If(fixture.Create<bool>())
                .Then(Mock.Of<Action>())
                .Else(Mock.Of<Action>())
                .EndIf();

                result.Should().BeOfType(typeof(Foo), because: "The caller needs to have a way to get back to the original object.");
            }
        }
    }
}
