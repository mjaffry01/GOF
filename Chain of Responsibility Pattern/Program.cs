// Handler
public abstract class Logger
{
    public static int INFO = 1;
    public static int DEBUG = 2;
    public static int ERROR = 3;

    protected int level;
    protected Logger nextLogger;

    public void SetNextLogger(Logger nextLogger) => this.nextLogger = nextLogger;

    public void LogMessage(int level, string message)
    {
        if (this.level <= level)
        {
            Write(message);
        }
        nextLogger?.LogMessage(level, message);
    }

    protected abstract void Write(string message);
}

// Concrete Handlers
public class ConsoleLogger : Logger
{
    public ConsoleLogger(int level) => this.level = level;
    protected override void Write(string message) => Console.WriteLine($"Standard Console::Logger: {message}");
}

public class ErrorLogger : Logger
{
    public ErrorLogger(int level) => this.level = level;
    protected override void Write(string message) => Console.WriteLine($"Error Console::Logger: {message}");
}

// Usage
class Program
{
    static void Main()
    {
        Logger errorLogger = new ErrorLogger(Logger.ERROR);
        Logger consoleLogger = new ConsoleLogger(Logger.INFO);
        Logger fileLogger = new FileLogger(Logger.DEBUG);
        errorLogger.SetNextLogger(consoleLogger);
        consoleLogger.SetNextLogger(fileLogger);
        errorLogger.LogMessage(Logger.INFO, "This is an information.");
        errorLogger.LogMessage(Logger.DEBUG, "This is a debug level information.");
        errorLogger.LogMessage(Logger.ERROR, "This is an error information.");
    }
}


// Start chain
// Standard Console::Logger: This is an information.
