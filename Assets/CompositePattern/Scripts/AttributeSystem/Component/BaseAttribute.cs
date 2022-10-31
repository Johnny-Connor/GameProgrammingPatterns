public class BaseAttribute
{
    private float _baseValue;
    private float _baseMultiplier;

    public BaseAttribute(float baseValue, float baseMultiplier)
    {
        _baseValue = baseValue;
        _baseMultiplier = baseMultiplier;
    }

    public int BaseValue { get; private set; }

    public int BaseMultiplier { get; private set; }
}
