namespace DecoratorPatterN;

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee Coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        Coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return Coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return Coffee.GetCost();
    }
}