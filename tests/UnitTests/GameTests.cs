using Domain;
using FluentAssertions;
using Xunit;

namespace UnitTests;

public class GameTests
{
    private readonly Game _game;

    public GameTests()
    {
        _game = new Game();
    }

    [Fact]
    public void FrameCount_ShouldBe10()
    {
        // arrange
        // act
        var framesCount = _game.FramesNumber();

        // assert
        framesCount.Should().Be(10);
    }

    [Fact]
    public void FrameHas1orMoreRolls()
    {
        // arrange
        // act
        var totalNumberRolls = _game.TotalNumberRolls();

        // assert 
        totalNumberRolls.Should().BeGreaterThanOrEqualTo(10);
        totalNumberRolls.Should().BeLessThanOrEqualTo(20);
    }

    [Fact]
    public void TestAllZeros()
    {
        // arrange
        // act
        RollsMany(framesCount: 10, pins: 0);

        // assert
        _game.Score().Should().Be(0);
    }

    [Fact]
    public void TestAllOnes()
    {
        // arrange
        // act
        RollsMany(framesCount: 10, pins: 1);

        // assert
        _game.Score().Should().Be(20);
    }

    private void RollsMany(int framesCount, int pins)
    {
        for (var frameIndex = 0; frameIndex < framesCount; frameIndex++)
        {
            _game.Roll(pins);
            _game.Roll(pins);
        }
    }
}