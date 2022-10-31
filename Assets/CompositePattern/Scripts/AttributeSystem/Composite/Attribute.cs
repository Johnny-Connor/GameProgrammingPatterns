public class Attribute : BaseAttribute
{
    private RawBonus[] _rawBonuses;
    private FinalBonus[] _finalBonuses;
    private int _finalValue;

    public Attribute(float startingValue, float baseMultiplier) : base(startingValue, baseMultiplier)
    {

    }

    public void AddRawBonus(RawBonus bonus)
    {
    }

    public void AddFinalBonus(FinalBonus bonus)
    {
    }

    public void RemoveRawBonus(RawBonus bonus)
    {
    }

    public int CalculateValue()
    {
        return 0;
    }

    public int final { get; private set; }
}
