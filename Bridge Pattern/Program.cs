// Implementor Interface
public interface IRenderer
{
    void RenderCircle(float radius);
}

// Concrete Implementors
public class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing circle with radius {radius} using vectors.");
    }
}

public class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing circle with radius {radius} using pixels.");
    }
}

// Abstraction
public abstract class Shape
{
    protected IRenderer renderer;
    public Shape(IRenderer renderer) => this.renderer = renderer;
    public abstract void Draw();
}

// Refined Abstraction
public class Circle : Shape
{
    private float radius;
    public Circle(IRenderer renderer, float radius) : base(renderer)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        renderer.RenderCircle(radius);
    }
}

// Usage
Shape circle = new Circle(new VectorRenderer(), 5.0f);
circle.Draw();
