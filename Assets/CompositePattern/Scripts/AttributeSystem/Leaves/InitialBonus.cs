// Bonus classes (Leaves) are grouped by Attributes (Composites).
// Initial Bonuses are applied on the starting value of an attribute.
public class InitialBonus : BaseAttribute
{
    /*
    The base keyword is used to override a functionality while still maintaining it.
    Note: the override keyword isn't used because inherited constructors are automatically
    overridden.
    */
    public InitialBonus(int baseValue, decimal basePercentage) : base(baseValue, basePercentage)
    {
    }
}
