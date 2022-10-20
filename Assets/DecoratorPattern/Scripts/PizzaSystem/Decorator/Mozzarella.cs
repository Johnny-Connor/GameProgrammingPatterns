using UnityEngine; // Using for Debug.Log.

public class Mozzarella : PizzaDecorator
{
    public Mozzarella(IPizza newPizza) : base(newPizza)
    {
        Debug.Log("Adding Mozzarella");
    }

    public override decimal GetCost()
    {
        return tempPizza.GetCost() + 3.00m;
    }

    public override string GetDescription()
    {
        return tempPizza.GetDescription() + ", mozzarella";
    }
}
