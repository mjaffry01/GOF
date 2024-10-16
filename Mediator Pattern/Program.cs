// Mediator Interface
public interface IMediator
{
    void SendMessage(string message, Colleague colleague);
}

// Colleague Class
public abstract class Colleague
{
    protected IMediator mediator;
    public Colleague(IMediator mediator) => this.mediator = mediator;
}

// Concrete Colleagues
public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(IMediator mediator) : base(mediator) { }
    public void Send(string message) => mediator.SendMessage(message, this);
    public void Notify(string message) => Console.WriteLine($"Colleague1 gets message: {message}");
}

public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(IMediator mediator) : base(mediator) { }
    public void Send(string message) => mediator.SendMessage(message, this);
    public void Notify(string message) => Console.WriteLine($"Colleague2 gets message: {message}");
}

// Concrete Mediator
public class ConcreteMediator : IMediator
{
    public ConcreteColleague1 Colleague1 { get; set; }
    public ConcreteColleague2 Colleague2 { get; set; }

    public void SendMessage(string message, Colleague colleague)
    {
        if (colleague == Colleague1)
            Colleague2.Notify(message);
        else
            Colleague1.Notify(message);
    }
}

// Usage
class Program
{
    static void Main()
    {
        ConcreteMediator mediator = new ConcreteMediator();
        ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
        ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);
        mediator.Colleague1 = colleague1;
        mediator.Colleague2 = colleague2;
        colleague1.Send("How are you?");
        colleague2.Send("Fine, thank you.");
    }
}
