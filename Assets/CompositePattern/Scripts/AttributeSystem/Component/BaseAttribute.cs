/*
The BaseAttribute class (Component) is a blueprint for how attributes (Composite and Leaves)
will work.
*/
public abstract class BaseAttribute
{
    private int _baseValue;
    private decimal _basePercentage;

    public BaseAttribute(int baseValue, decimal basePercentage)
    {
        _baseValue = baseValue;
        _basePercentage = basePercentage;
    }

    public int GetBaseValue()
    {
        return _baseValue;
    }

    public decimal GetBasePercentage()
    {
        return _basePercentage;
    }
}
