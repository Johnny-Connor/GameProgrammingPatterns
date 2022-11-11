// Bonuses (Leaves) can be grouped by Attributes (Composites).
public class Bonus : BaseAttribute
{
    /*
    The base keyword is used to override a functionality while still maintaining it.
    Note: the override keyword isn't used because inherited constructors are automatically
    overridden.
    */
    public Bonus(int baseValue) : base(baseValue)
    {
    }
}
