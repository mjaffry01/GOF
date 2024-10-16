// Subject
public class Subject
{
    private List<IObserver> observers = new List<IObserver>();
    private int _state;

    public int State
    {
        get => _state;
        set { _state = value; Notify(); }
    }

    public void Attach(IObserver observer) => observers.Add(observer);
    public void Detach(IObserver observer) => observers.Remove(observer);
    private void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
}

// Observer Interface
public interface IObserver
{
    void Update();
}

// Concrete Observer
public class ConcreteObserver : IObserver
{
    private Subject _subject;
    public ConcreteObserver(Subject subject) => _subject = subject;
    public void Update() => Console.WriteLine($"Observer notified. New State: {_subject.State}");
}

// Usage
class Program
{
    static void Main()
    {
        Subject subject = new Subject();
        ConcreteObserver observer1 = new ConcreteObserver(subject);
        ConcreteObserver observer2 = new ConcreteObserver(subject);
        subject.Attach(observer1);
        subject.Attach(observer2);
        subject.State = 5;
    }
}
