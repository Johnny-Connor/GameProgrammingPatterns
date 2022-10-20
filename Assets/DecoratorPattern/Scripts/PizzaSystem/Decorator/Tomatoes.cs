using UnityEngine; // Using for Debug.Log.

public class Tomatoes : PizzaDecorator
{
    public Tomatoes(IPizza newPizza) : base(newPizza)
    {
        Debug.Log("Adding Tomatoes");
    }

    public override decimal GetCost()
    {
        return tempPizza.GetCost() + 1.50m;
    }

    public override string GetDescription()
    {
        return tempPizza.GetDescription() + ", tomatoes";
    }
}
