// Aggregate Interface
using System.Collections;

public interface IAggregate
{
    IIterator CreateIterator();
}

// Iterator Interface
public interface IIterator
{
    bool HasNext();
    object Next();
}

// Concrete Aggregate
public class ConcreteAggregate : IAggregate
{
    private ArrayList _items = new ArrayList();

    public IIterator CreateIterator() => new ConcreteIterator(this);
    public int Count => _items.Count;
    public object this[int index]
    {
        get => _items[index];
        set => _items.Insert(index, value);
    }
}

// Concrete Iterator
public class ConcreteIterator : IIterator
{
    private ConcreteAggregate _aggregate;
    private int _current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate) => _aggregate = aggregate;

    public bool HasNext() => _current < _aggregate.Count;

    public object Next() => _aggregate[_current++];
}

// Usage
class Program
{
    static void Main()
    {
        ConcreteAggregate aggregate = new ConcreteAggregate();
        aggregate[0] = "Item 1";
        aggregate[1] = "Item 2";
        aggregate[2] = "Item 3";
        aggregate[3] = "Item 4";
        IIterator iterator = aggregate.CreateIterator();
        while (iterator.HasNext())
        {
            string item = (string)iterator.Next();
            Console.WriteLine(item);
        }
    }
}

