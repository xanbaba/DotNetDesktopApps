namespace PatternsHw.DataBase;

public class MsSqlConnection : IDataBaseConnection
{
    public void Connect()
    {
        Console.WriteLine("MsSqlConnection Connect");
    }

    public void Disconnect()
    {
        Console.WriteLine("MsSqlConnection Disconnect");
    }
}