// Product
public class House
{
    public string Walls { get; set; }
    public string Roof { get; set; }
    public string Doors { get; set; }
}

// Builder Interface
public interface IHouseBuilder
{
    void BuildWalls();
    void BuildRoof();
    void BuildDoors();
    House GetHouse();
}

// Concrete Builder
public class ConcreteHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildWalls() => _house.Walls = "Concrete Walls";
    public void BuildRoof() => _house.Roof = "Concrete Roof";
    public void BuildDoors() => _house.Doors = "Wooden Doors";
    public House GetHouse() => _house;
}

// Director
public class Director
{
    public void Construct(IHouseBuilder builder)
    {
        builder.BuildWalls();
        builder.BuildRoof();
        builder.BuildDoors();
    }
}

// Usage
class Program
{
    static void Main()
    {
        IHouseBuilder builder = new ConcreteHouseBuilder();
        Director director = new Director();
        director.Construct(builder);
        House house = builder.GetHouse();
        Console.WriteLine($"House with {house.Walls}, {house.Roof}, and {house.Doors} is built.");
    }
}

