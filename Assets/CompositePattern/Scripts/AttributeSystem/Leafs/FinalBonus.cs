public class FinalBonus : BaseAttribute
{
    /*
    The base keyword is used to override a functionality while still maintaining it.
    Note: the override keyword isn't used because inherited constructors are automatically
    overridden.
    */
    public FinalBonus(float baseValue, float baseMultiplier) : base(baseValue, baseMultiplier)
    {
    }
}
