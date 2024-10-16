// Component
public abstract class Beverage
{
    public abstract string GetDescription();
    public abstract double GetCost();
}

// Concrete Component
public class Espresso : Beverage
{
    public override string GetDescription() => "Espresso";
    public override double GetCost() => 1.99;
}

// Decorator
public abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;
    public CondimentDecorator(Beverage beverage) => this.beverage = beverage;
}

// Concrete Decorators
public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage) { }

    public override string GetDescription() => beverage.GetDescription() + ", Milk";
    public override double GetCost() => beverage.GetCost() + 0.50;
}

// Usage
Beverage beverage = new Espresso();
beverage = new Milk(beverage);
Console.WriteLine($"{beverage.GetDescription()} costs ${beverage.GetCost()}");
