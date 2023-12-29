namespace Domain;

public class Roll
{
    public int Pin { get; private set; }

    public Roll()
    {
        Pin = 0;        
    }

    public void Play(int pins)
    {
        Pin = pins;
    }
}
