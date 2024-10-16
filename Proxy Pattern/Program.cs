// Subject Interface
public interface IImage
{
    void Display();
}

// Real Subject
public class RealImage : IImage
{
    private string _filename;
    public RealImage(string filename)
    {
        _filename = filename;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading {_filename} from disk.");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying {_filename}.");
    }
}

// Proxy
public class ProxyImage : IImage
{
    private RealImage _realImage;
    private string _filename;

    public ProxyImage(string filename)
    {
        _filename = filename;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_filename);
        }
        _realImage.Display();
    }
}

// Usage
class Program
{
    static void Main()
    {
        IImage image = new ProxyImage("image.jpg");
        image.Display();
    }
}
