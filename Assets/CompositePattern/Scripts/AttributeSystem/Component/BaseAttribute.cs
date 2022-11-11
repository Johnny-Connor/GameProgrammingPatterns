/*
The BaseAttribute class (Component) is a blueprint for how a stat (Composites and Leaves)
will work.
*/
public abstract class BaseAttribute
{
    protected int _value;

    public BaseAttribute(int startingValue)
    {
        _value = startingValue;
    }

    public virtual int GetValue()
    {
        return _value;
    }
}
