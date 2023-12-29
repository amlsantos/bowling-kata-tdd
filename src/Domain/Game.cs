
namespace Domain;

public class Game
{
    private const int FramesCount = 10;
    private Frame[] Frames { get; init; }

    public Game()
    {
        Frames = new Frame[FramesCount] 
        { new(), new(), new(), new(), new(), new(), new(), new(), new(), new() };
    }

    public int FramesNumber()
    {
        return Frames.Length;
    }

    public int TotalNumberRolls()
    {
        return Frames
        .Select(f => f.Rolls.Length)
        .Sum();
    }

    public void Roll(int numberOfPins)
    {

    }

    public int Score()
    {
        return -1;
    }
}
