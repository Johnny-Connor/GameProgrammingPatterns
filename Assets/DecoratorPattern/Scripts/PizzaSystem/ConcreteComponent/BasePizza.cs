public class BasePizza : IPizza
{
    public decimal GetPrice()
    {
        return 5.00m;
    }

    public string GetIngredients()
    {
        return "Dough (base)";
    }
}
