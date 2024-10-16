// Target Interface
public interface ITarget
{
    void Request();
}

// Adaptee Class
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request called.");
    }
}

// Adapter Class
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;
    public Adapter(Adaptee adaptee) => _adaptee = adaptee;

    public void Request()
    {
        // Translate the request to a specific request
        _adaptee.SpecificRequest();
    }
}

// Usage
class Program
{
    static void Main()
    {
        ITarget target = new Adapter(new Adaptee());
        target.Request();
    }
}
