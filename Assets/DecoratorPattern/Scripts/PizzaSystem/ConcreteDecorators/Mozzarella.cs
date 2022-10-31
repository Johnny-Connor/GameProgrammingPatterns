using UnityEngine; // Using for Debug.Log.

public class Mozzarella : PizzaDecorator
{
    /*
    The base keyword is used to override a functionality while still maintaining it.
    Note: the override keyword isn't used because inherited constructors are automatically
    overridden.
    */
    public Mozzarella(IPizza newPizza) : base(newPizza)
    {
        Debug.Log("Adding Mozzarella");
    }

    /*
    Returns the GetCost/GetDescription from tempPizza and adds a value to it.
    Reminder: tempPizza references the IPizza newPizza inserted in the constructor of
    PizzaDecorator.cs, meaning that ultimately, in this example, tempPizza is the _pizza
    object from PizzaSystemControls.cs.
    */
    public override decimal GetCost()
    {
        return tempPizza.GetCost() + 3.00m;
    }

    public override string GetDescription()
    {
        return tempPizza.GetDescription() + ", mozzarella";
    }
}
