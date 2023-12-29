
namespace Domain;

public class Game
{
    private const int FramesCount = 10;
    private int currentFrame = 0;

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
        var frame = Frames[currentFrame];
        frame.Rool(numberOfPins);

        if (frame.IsFinished())
            currentFrame +=1;
        
    }

    public int Score()
    {
        var score = 0;
        for(var i=0; i<FramesCount; i++)
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
