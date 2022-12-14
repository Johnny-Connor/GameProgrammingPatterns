/*
Possible questions regarding the Decorator class:

Q - PizzaDecorator (Decorator) is not an IPizza (IComponent). Why is it implementing it?
A - Although the PizzaDecorator and its children (ConcreteDecorators) indeed are not
abstractly IPizzas, it is highly recommended to make the PizzaDecorator implement said
interface for his children: not having the ingredients being of type IPizza makes adding
them to the BasePizza (ConcreteComponent) much more difficulty to do, if even possible. For
instance, "_pizza = new Mozzarella(_pizza)" (line from PizzaSystemControls.cs) would result
in error CS0266, as _pizza (IPizza type) would not be able to receive a value of type
Mozzarella.
To cope with this not so logical abstraction, one can bring up the fact that the ingredients
of an IPizza are part of an IPizza, indirectly making them an IPizza.

Q - What is the purpose of this class (Decorator) in this pattern? Would not it be easier to
just remove it and make its children (Concrete Decorators) inherit directly from IPizza
(Component) instead?
A - To eliminate code duplication. Without this class, each ingredient would require the
tempPizza object to be declared and have its attribution operation inside their
constructors, violating the "Don't Repeat Yourself" (DRY) principle.
*/
public abstract class PizzaDecorator : IPizza
{
    protected IPizza tempPizza;

    /*
    Reminder: IPizza is an object (not a variable), so newPizza is passed by reference (not
    by value).
    */
    public PizzaDecorator(IPizza newPizza)
    {
        tempPizza = newPizza;
    }

    public abstract decimal GetPrice();

    public abstract string GetIngredients();
}
