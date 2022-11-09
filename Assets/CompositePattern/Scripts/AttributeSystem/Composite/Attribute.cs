/*
Using for List<T>, a class which provides many methods to search, sort, and manipulate lists
of any type (Generics).
*/
using System.Collections.Generic;

/*
The Attribute class (Composite) is a node which can group multiple bonuses (Leaves). This
makes it possible, for example, to isolate the bonuses a buff/potion/weapon may give.
*/
public class Attribute : BaseAttribute
{
    /*
    Usually, only one array of Component type is required to group the Leaves. However, in
    this case, in order to make sure that the bonuses (Leaves) are aplied in the planned
    order (in CalculateTotalValue function), there will be an array for each type of bonus.
    */
    private List<InitialBonus> _initialBonuses;
    private List<FinalBonus> _finalBonuses;

    public Attribute(int startingValue) : base(startingValue, 1)
    {
        _initialBonuses = new List<InitialBonus>();
        _finalBonuses = new List<FinalBonus>();
    }

    public void AddInitialBonus(InitialBonus bonus)
    {
        _initialBonuses.Add(bonus);
    }

    public void RemoveInitialBonus(InitialBonus bonus)
    {
        foreach (InitialBonus i in _initialBonuses)
        {
            if (bonus.GetBaseValue() == i.GetBaseValue() && bonus.GetBasePercentage() == i.GetBasePercentage())
            {
                bonus = i;
                break;
            }
        }

        _initialBonuses.Remove(bonus);
    }

    public void AddFinalBonus(FinalBonus bonus)
    {
        _finalBonuses.Add(bonus);
    }

    public void RemoveFinalBonus(FinalBonus bonus)
    {
        foreach (FinalBonus i in _finalBonuses)
        {
            if (bonus.GetBaseValue() == i.GetBaseValue() && bonus.GetBasePercentage() == i.GetBasePercentage())
            {
                bonus = i;
                break;
            }
        }

        _finalBonuses.Remove(bonus);
    }

    /*
    Gathers the bonuses (Leaves) from this attribute (Composite) to calculate its total
    value.
    */
    private decimal CalculateTotalValue()
    {
        int totalInitialValueBonus = 0;
        decimal totalInitialPercentageBonus = 0;

        foreach (InitialBonus bonus in _initialBonuses)
        {
            totalInitialValueBonus += bonus.GetBaseValue();
            totalInitialPercentageBonus += bonus.GetBasePercentage();
        }

        int totalFinalValueBonus = 0;
        decimal totalFinalPercentageBonus = 0;

        foreach (FinalBonus bonus in _finalBonuses)
        {
            totalFinalValueBonus += bonus.GetBaseValue();
            totalFinalPercentageBonus +=  bonus.GetBasePercentage();
        }

        return ( (GetBaseValue() * (1 + totalInitialPercentageBonus) + totalInitialValueBonus) * (1 + totalFinalPercentageBonus) + totalFinalValueBonus );
    }

    public decimal GetTotalValue()
    {
        return CalculateTotalValue();
    }
}
