/*
Using for List<T>, a class that provides many methods to search, sort, and manipulate lists
of any type (Generics).
*/
using System.Collections.Generic;

/*
The Attribute class (Composite) is a node that can group bonuses (Leaves) and other
attributes. This makes it possible, for example, to manage the bonuses a buff/potion/
weapon will have, as well as manage these same items when they are being used by another
item.
*/
public class Attribute : BaseAttribute
{
    private List<BaseAttribute> _baseAttributes;

    public Attribute(int startingValue) : base(startingValue)
    {
        _baseAttributes = new List<BaseAttribute>();
    }

    public void AddBaseAttribute(BaseAttribute baseAttribute)
    {
        _baseAttributes.Add(baseAttribute);
    }

    public void RemoveBaseAttribute(BaseAttribute baseAttribute)
    {
        _baseAttributes.Remove(baseAttribute);
    }

    public bool ContainsBaseAttribute(BaseAttribute baseAttribute)
    {
        return _baseAttributes.Contains(baseAttribute);
    }

    public override int GetValue()
    {
        /*
        Gathers the attributes (Composites) and bonuses (Leaves) from this attribute to
        calculate its total value.
        */
        int CalculateValue()
        {
            int totalValue = _value;

            foreach (BaseAttribute i in _baseAttributes)
            {
                totalValue += i.GetValue();
            }

            return totalValue;
        }

        return CalculateValue();
    }
}
