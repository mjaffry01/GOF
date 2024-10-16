// Memento
public class Memento
{
    public string State { get; private set; }
    public Memento(string state) => State = state;
}

// Originator
public class Originator
{
    public string State { get; set; }
    public Memento SaveState() => new Memento(State);
    public void RestoreState(Memento memento) => State = memento.State;
}

// Caretaker
public class Caretaker
{
    public Memento Memento { get; set; }
}

// Usage
class Program
{
    static void Main()
    {
        Originator originator = new Originator { State = "State 1" };
        Caretaker caretaker = new Caretaker { Memento = originator.SaveState() };
        originator.State = "State 2";
        originator.RestoreState(caretaker.Memento);
        Console.WriteLine(originator.State);
    }
}


