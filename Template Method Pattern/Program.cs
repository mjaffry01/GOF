// Abstract Class
public abstract class DataProcessor
{
    public void Process()
    {
        ReadData();
        ProcessData();
        SaveData();
    }

    protected abstract void ReadData();
    protected abstract void ProcessData();
    protected void SaveData() => Console.WriteLine("Saving data to database.");
}

// Concrete Class
public class CsvDataProcessor : DataProcessor
{
    protected override void ReadData() => Console.WriteLine("Reading data from CSV file.");
    protected override void ProcessData() => Console.WriteLine("Processing CSV data.");
}

// Usage
