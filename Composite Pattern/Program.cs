// Component
public abstract class Graphic
{
    public abstract void Draw();
}

// Leaf
public class Circle : Graphic
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

// Composite
public class CompositeGraphic : Graphic
{
    private List<Graphic> _children = new List<Graphic>();

    public void Add(Graphic graphic) => _children.Add(graphic);
    public void Remove(Graphic graphic) => _children.Remove(graphic);

    public override void Draw()
    {
        foreach (var child in _children)
        {
            child.Draw();
        }
    }
}

// Usage
class Program
{
    static void Main()
    {
        CompositeGraphic composite = new CompositeGraphic();
        composite.Add(new Circle());
        composite.Add(new Circle());
        composite.Add(new Circle());
        composite.Draw();
    }
}

