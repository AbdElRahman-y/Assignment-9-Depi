namespace Session09Assignment;

// ---------------- Q5: Singleton ----------------
public class AppLogger
{
    private static AppLogger? _instance;

    private AppLogger() { }

    public static AppLogger GetLogger()
    {
        _instance ??= new AppLogger();
        return _instance;
    }

    public void Log(string message) => Console.WriteLine($"[LOG] {message}");
}
