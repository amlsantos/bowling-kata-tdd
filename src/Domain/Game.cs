
namespace Domain;

public class Game
{
    private const int FramesCount = 10;
    private Frame[] Frames { get; init; }

    public Game()
    {
        Frames = new Frame[FramesCount];
    }

    public int FramesNumber()
    {
        return Frames.Length;
    }

    public int RollsNumber()
    {
        return 10;
    }
}
