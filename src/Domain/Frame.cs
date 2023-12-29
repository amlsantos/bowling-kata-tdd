namespace Domain;

public class Frame
{
    private const int RollsCount = 2;
    private int remainingPins = 10;
    public Roll[] Rolls { get; init; }

    private int currentPlay = 0;

    public Frame()
    {
        Rolls = new Roll[RollsCount] { new(), new() };
    }

    public void Rool(int pins)
    {
        if (currentPlay == 0)
            RoolFirst(pins);
        else if (currentPlay == 1)
            RollSecond(pins);
        else
            throw new InvalidOperationException("Invalid roll index");

        currentPlay += 1;
    }

    private void RoolFirst(int pins)
    {
        Rolls[0].Play(pins);
        remainingPins -= pins;
    }

    private void RollSecond(int pins)
    {
        if (remainingPins == 0)
            return;

        Rolls[1].Play(pins);
        remainingPins -= pins;
    }

    public int GetScore()
    {
        return Rolls[0].Pin + Rolls[1].Pin;
    }

    public int GetScore(int roolIndex)
    {
        return Rolls[roolIndex].Pin;
    }

    public bool IsFinished()
    {
        return currentPlay > 1 || remainingPins == 0;
    }

    public bool IsSpare()
    {
        return IsFinished() && remainingPins == 0;
    }

    public bool IsStrike()
    {
        return remainingPins == 0 && (Rolls[0].Pin == 10 || Rolls[1].Pin == 10);
    }
}
