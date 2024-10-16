// Flyweight Interface
public interface IShape
{
    void Draw(string color);
}

// Concrete Flyweight
public class Circle : IShape
{
    public void Draw(string color)
    {
        Console.WriteLine($"Drawing a {color} circle.");
    }
}

// Flyweight Factory
public class ShapeFactory
{
    private static Dictionary<string, IShape> circleMap = new Dictionary<string, IShape>();

    public static IShape GetCircle()
    {
        string key = "circle";
        if (!circleMap.ContainsKey(key))
        {
            circleMap[key] = new Circle();
            Console.WriteLine("Creating new circle object.");
        }
        return circleMap[key];
    }
}

// Usage
class Program
{
    static void Main()
    {
        IShape circle1 = ShapeFactory.GetCircle();
        circle1.Draw("Red");
        IShape circle2 = ShapeFactory.GetCircle();
        circle2.Draw("Green");
    }
}

