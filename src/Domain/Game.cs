
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

    public int RollsNumber()
    {
        return Frames
        .Select(f => f.Rolls.Length)
        .Sum();
    }
}
