public class BasePizza : IPizza
{
    public decimal GetCost()
    {
        return 5.00m;
    }

    public string GetDescription()
    {
        return "Base Pizza";
    }
}
