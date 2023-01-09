// Using for Debug.Log.
using UnityEngine;

public class Mozzarella : PizzaDecorator
{
    /*
    The base keyword is used to override a functionality while still maintaining it.
    Note: the override keyword is not used because inherited constructors are automatically
    overridden.
    */
    public Mozzarella(IPizza newPizza) : base(newPizza)
    {
        Debug.Log("Adding mozzarella.");
    }

    /*
    Returns the GetPrice/GetIngredients from tempPizza and adds a value to it.
    Reminder: tempPizza references the IPizza newPizza inserted in the constructor of
    PizzaDecorator.cs, meaning that, ultimately, in this example, tempPizza is the _pizza
    object from PizzaSystemControls.cs.
    */
    public override decimal GetPrice()
    {
        return tempPizza.GetPrice() + 3.00m;
    }

    public override string GetIngredients()
    {
        return tempPizza.GetIngredients() + ", mozzarella";
    }
}
