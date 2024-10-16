// Abstract Products
public interface IButton
{
    void Render();
}

public interface ICheckbox
{
    void Render();
}

// Concrete Products for Windows
public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Render a button in Windows style.");
}

public class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Render a checkbox in Windows style.");
}

// Concrete Products for Mac
public class MacButton : IButton
{
    public void Render() => Console.WriteLine("Render a button in Mac style.");
}

public class MacCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Render a checkbox in Mac style.");
}

// Abstract Factory
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

// Concrete Factories
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}

// Usage
class Program
{
    static void Main()
    {
        IGUIFactory factory = new WindowsFactory();
        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();
        button.Render();
        checkbox.Render();
        factory = new MacFactory();
        button = factory.CreateButton();
        checkbox = factory.CreateCheckbox();
        button.Render();
        checkbox.Render();
    }
}



