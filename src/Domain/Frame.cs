namespace Domain;

public class Frame
{
    private const int RollsCount = 2;
    public Roll[] Rolls {get; init;}

    public Frame()
    {
        Rolls = new Roll[RollsCount] { new(), new() };
    }
}
