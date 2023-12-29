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
        var framesCount = game.FramesNumber();

        // assert
        framesCount.Should().Be(10);
    }

    [Fact]
    public void FrameHas1orMoreRolls()
    {
        // arrange
        var game = new Game();

        // act
        var rollsCount = game.RollsNumber();

        // assert 
        rollsCount.Should().BeGreaterThanOrEqualTo(10);
        rollsCount.Should().BeLessThanOrEqualTo(20);
    }
}