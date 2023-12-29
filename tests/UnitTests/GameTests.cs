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
        var totalNumberRolls = game.TotalNumberRolls();

        // assert 
        totalNumberRolls.Should().BeGreaterThanOrEqualTo(10);
        totalNumberRolls.Should().BeLessThanOrEqualTo(20);
    }

    [Fact]
    public void TestAllZeros()
    {
        // arrange
        var game = new Game();
        var framesCount = 10;

        // act
        for(var frameIndex=0; frameIndex<framesCount; frameIndex++)
        {
            game.Roll(0);
        }

        // assert
        game.Score().Should().Be(0);
    }
}