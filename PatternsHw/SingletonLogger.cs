using System.Text;

namespace PatternsHw;

public class SingletonLogger
{
    private static SingletonLogger? _instance;

    public static SingletonLogger Instance => _instance ??= new SingletonLogger();

    public static string? FilePath { get; set; }

    private SingletonLogger()
    {
    }

    public void Log(LogType logType, string message)
    {
        if (FilePath == null)
        {
            throw new ArgumentException($"Set value to {nameof(FilePath)} property to call {nameof(Log)} method");
        }

        var logTemplate = new StringBuilder();
        switch (logType)
        {
            case LogType.Info:
                logTemplate.Append("[Info] ");
                break;
            case LogType.Warning:
                logTemplate.Append("[Warning] ");
                break;
            case LogType.Error:
                logTemplate.Append("[Error] ");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(logType), logType, null);
        }

        logTemplate.Append(message + '\n');
        File.AppendAllText(FilePath, logTemplate.ToString());
    }
}