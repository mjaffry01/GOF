// Command Interface
public interface ICommand
{
    void Execute();
}

// Receiver
public class Light
{
    public void TurnOn() => Console.WriteLine("The light is on.");
    public void TurnOff() => Console.WriteLine("The light is off.");
}

// Concrete Commands
public class TurnOnCommand : ICommand
{
    private Light _light;
    public TurnOnCommand(Light light) => _light = light;
    public void Execute() => _light.TurnOn();
}

public class TurnOffCommand : ICommand
{
    private Light _light;
    public TurnOffCommand(Light light) => _light = light;
    public void Execute() => _light.TurnOff();
}

// Invoker
public class RemoteControl
{
    private ICommand _command;
    public void SetCommand(ICommand command) => _command = command;
    public void PressButton() => _command.Execute();
}

// Usage
class Program
{
    static void Main()
    {
        Light light = new Light();
        ICommand turnOn = new TurnOnCommand(light);
        ICommand turnOff = new TurnOffCommand(light);
        RemoteControl remote = new RemoteControl();
        remote.SetCommand(turnOn);
        remote.PressButton();
        remote.SetCommand(turnOff);
        remote.PressButton();
    }
}

