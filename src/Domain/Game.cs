
namespace Domain;

public class Game
{
    private const int MaxFrames = 10;
    private int frameIndex = 0;

    private Frame[] Frames { get; init; }    

    public Game()
    {
        Frames = new Frame[MaxFrames] 
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
        var frame = Frames[frameIndex];
        frame.Rool(numberOfPins);

        if (frame.IsFinished())
            frameIndex +=1;
    }

    public int Score()
    {
        var score = 0;
        for(var i=0; i<MaxFrames; i++)
        {
            var frame = Frames[i];
            score += frame.GetScore();

            if (frame.IsSpare())
            {
                var nextFrame = Frames[i+1];
                var bonus = nextFrame.GetScore(0);
                score += bonus;
            }
        }

        return score;
    }
}
