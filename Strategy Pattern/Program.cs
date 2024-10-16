// Strategy Interface
public interface ISortStrategy
{
    void Sort(List<int> list);
}

// Concrete Strategies
public class BubbleSort : ISortStrategy
{
    public void Sort(List<int> list) => Console.WriteLine("Sorting using Bubble Sort.");
}

public class QuickSort : ISortStrategy
{
    public void Sort(List<int> list) => Console.WriteLine("Sorting using Quick Sort.");
}

// Context
public class SortContext
{
    private ISortStrategy _strategy;
    public void SetStrategy(ISortStrategy strategy) => _strategy = strategy;
    public void Sort(List<int> list) => _strategy.Sort(list);
}

// Usage
class Program
{
    static void Main()
    {
        var list = new List<int> { 1, 3, 2, 4, 5 };
        var context = new SortContext();
        context.SetStrategy(new BubbleSort());
        context.Sort(list);
        context.SetStrategy(new QuickSort());
        context.Sort(list);
    }
}
