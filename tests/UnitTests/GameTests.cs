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
        var framesCount = game.Frames;

        // assert
        framesCount.Should().Be(10);
    }
}