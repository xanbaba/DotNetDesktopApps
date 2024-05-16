namespace PatternsHw.DataBase;

public class SqlLiteConnection : IDataBaseConnection
{
    public void Connect()
    {
        Console.WriteLine("SqlLiteConnection Connect");
    }

    public void Disconnect()
    {
        Console.WriteLine("SqlLiteConnection Disconnect");
    }
}