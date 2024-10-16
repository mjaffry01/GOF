public abstract class Prototype
{
    public abstract Prototype Clone();
}

public class ConcretePrototype : Prototype
{
    public int Data { get; set; }

    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}

// Usage
class Program
{
    static void Main()
    {
        Prototype prototype = new ConcretePrototype { Data = 1 };
        Prototype clone = prototype.Clone() as ConcretePrototype;
        Console.WriteLine($"Original: {prototype.GetHashCode()}, Clone: {clone.GetHashCode()}");
    }
}
