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
    public void Roll_With0Pins_Returns0Score()
    {
        // arrange
        // act
        RollsMany(framesCount: 10, pins: 0);

        // assert
        _game.Score().Should().Be(0);
    }

    [Fact]
    public void Roll_With1PinEachPlay_Returns20Score()
    {
        // arrange
        // act
        RollsMany(framesCount: 10, pins: 1);

        // assert
        _game.Score().Should().Be(20);

    }

    [Fact]
    public void Roll_OneSpare_Returns20Score()
    {
        // arrange
        // act
        RollSpare(7, 3);
        _game.Roll(4);
        _game.Roll(2);

        RollsMany(framesCount: 8, pins: 0);

        // assert
        _game.Score().Should().Be(20);
    }

    [Fact]
    public void Roll_OneSpare_Returns16Score()
    {
        // arrange
        // act
        RollSpare(5, 5);
        _game.Roll(3);
        _game.Roll(0);

        RollsMany(framesCount: 8, pins: 0);

        // assert
        _game.Score().Should().Be(16);
    }

    private void RollSpare(int firstRoll, int secondRoll)
    {
        _game.Roll(firstRoll);
        _game.Roll(secondRoll);
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