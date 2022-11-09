// Bonus classes (Leaves) are grouped by Attributes (Composites).
/*
Final Bonuses are applied on the end value of an attribute, after the Initials Bonuses are
applied.
*/
public class FinalBonus : BaseAttribute
{
    /*
    The base keyword is used to override a functionality while still maintaining it.
    Note: the override keyword isn't used because inherited constructors are automatically
    overridden.
    */
    public FinalBonus(int baseValue, decimal basePercentage) : base(baseValue, basePercentage)
    {
    }
}
