// State Interface
public interface IState
{
    void Handle(Context context);
}

// Context
public class Context
{
    public IState State { get; set; }
    public Context(IState state) => State = state;
    public void Request() => State.Handle(this);
}

// Concrete States
public class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("State A handling request.");
        context.State = new ConcreteStateB();
    }
}

public class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("State B handling request.");
        context.State = new ConcreteStateA();
    }
}

// Usage
class Program
{
    static void Main()
    {
        Context context = new Context(new ConcreteStateA());
        context.Request();
        context.Request();
        context.Request();
        context.Request();
    }
}

