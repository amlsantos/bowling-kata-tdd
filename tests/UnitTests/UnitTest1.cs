using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class GameTests
{
    [Fact]
    public void FrameCount_ShouldBe10()
    {
        // arrange
        var game = new Game();

        // act
        var framesNUmber = game.Frames.Count;

        // assert
        framesNUmber.Should().be(10);
    }
}