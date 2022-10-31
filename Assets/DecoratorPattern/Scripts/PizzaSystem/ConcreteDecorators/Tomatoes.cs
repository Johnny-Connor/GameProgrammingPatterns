using UnityEngine; // Using for Debug.Log.

public class Tomatoes : PizzaDecorator
{
    /*
    The base keyword is used to override a functionality while still maintaining it.
    Note: the override keyword isn't used because inherited constructors are automatically
    overridden.
    */
    public Tomatoes(IPizza newPizza) : base(newPizza)
    {
        Debug.Log("Adding Tomatoes");
    }

    /*
    Returns the GetCost/GetDescription from tempPizza and adds a value to it.
    Reminder: tempPizza references the IPizza newPizza inserted in the constructor of
    PizzaDecorator.cs, meaning that ultimately, in this example, tempPizza is the _pizza
    object from PizzaSystemControls.cs.
    */
    public override decimal GetCost()
    {
        return tempPizza.GetCost() + 1.50m;
    }

    public override string GetDescription()
    {
        return tempPizza.GetDescription() + ", tomatoes";
    }
}
