// Product Interface
public interface IProduct
{
    void Operation();
}

// Concrete Products
public class ConcreteProductA : IProduct
{
    public void Operation() => Console.WriteLine("Operation of ConcreteProductA");
}

public class ConcreteProductB : IProduct
{
    public void Operation() => Console.WriteLine("Operation of ConcreteProductB");
}

// Creator Abstract Class
public abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

// Concrete Creators
public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod() => new ConcreteProductA();
}

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod() => new ConcreteProductB();
}

// Usage
class Program
{
    static void Main()
    {
        Creator creator = new ConcreteCreatorA();
        IProduct product = creator.FactoryMethod();
        product.Operation();
        creator = new ConcreteCreatorB();
        product = creator.FactoryMethod();
        product.Operation();
    }
}

