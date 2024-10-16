public sealed class Singleton
{
    private static readonly Singleton _instance = new Singleton();

    // Private constructor prevents instantiation from other classes
    private Singleton() { }

    public static Singleton Instance => _instance;

    public void DoSomething()
    {
        Console.WriteLine("Singleton instance invoked.");
    }
}

 class Program
    {
    static void Main()
{
    Singleton.Instance.DoSomething();
}
}