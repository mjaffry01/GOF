// Visitor Interface
public interface IVisitor
{
    void Visit(ElementA element);
    void Visit(ElementB element);
}

// Element Interface
public abstract class Element
{
    public abstract void Accept(IVisitor visitor);
}

// Concrete Elements
public class ElementA : Element
{
    public override void Accept(IVisitor visitor) => visitor.Visit(this);
}

public class ElementB : Element
{
    public override void Accept(IVisitor visitor) => visitor.Visit(this);
}

// Concrete Visitor
public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA element) => Console.WriteLine("Visited ElementA");
    public void Visit(ElementB element) => Console.WriteLine("Visited ElementB");
}

// Usage
class Program
{
    static void Main()
    {
        Element[] elements = { new ElementA(), new ElementB() };
        IVisitor visitor = new ConcreteVisitor();
        foreach (Element element in elements)
        {
            element.Accept(visitor);
        }
    }
}


