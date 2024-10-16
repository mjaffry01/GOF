// Subsystem Classes
public class CPU
{
    public void Freeze() => Console.WriteLine("CPU Freeze");
    public void Jump(long position) => Console.WriteLine($"CPU Jump to {position}");
    public void Execute() => Console.WriteLine("CPU Execute");
}

public class Memory
{
    public void Load(long position, byte[] data) => Console.WriteLine($"Memory Load at {position}");
}

public class HardDrive
{
    public byte[] Read(long lba, int size) => new byte[size];
}

// Facade
public class Computer
{
    private CPU cpu = new CPU();
    private Memory memory = new Memory();
    private HardDrive hardDrive = new HardDrive();

    public void Start()
    {
        cpu.Freeze();
        memory.Load(0, hardDrive.Read(0, 1024));
        cpu.Jump(0);
        cpu.Execute();
    }
}

// Usage
Computer computer = new Computer();
computer.Start();
