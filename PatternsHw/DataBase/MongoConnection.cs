namespace PatternsHw.DataBase;

public class MongoConnection : IDataBaseConnection
{
    public void Connect()
    {
        Console.WriteLine("MongoConnection Connect");
    }

    public void Disconnect()
    {
        Console.WriteLine("MongoConnection Disconnect");
    }
}