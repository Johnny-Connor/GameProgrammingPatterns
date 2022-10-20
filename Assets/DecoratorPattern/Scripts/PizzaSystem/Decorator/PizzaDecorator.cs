public abstract class PizzaDecorator : IPizza
{
    protected IPizza tempPizza;

    public PizzaDecorator(IPizza newPizza)
    {
        tempPizza = newPizza;
    }

    public abstract decimal GetCost();

    public abstract string GetDescription();
}
