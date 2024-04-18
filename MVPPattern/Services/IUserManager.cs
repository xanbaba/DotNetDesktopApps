using System.IO;
using MVPPattern.Models;
using Newtonsoft.Json;

namespace MVPPattern.Services;

public interface IUserManager
{
    void AddUser(User user);
    void RemoveUser(User user);
    IEnumerable<User> GetAllUsers();
}

public class JsonUserManager : IUserManager
{
    private const string FileName = "users.json";

    public JsonUserManager()
    {
        if (File.Exists(FileName))
        {
            return;
        }

        using var stream = new StreamWriter(File.Create(FileName));
        stream.Write("[]");
    }
    
    public void AddUser(User user)
    {
        
    }

    public void RemoveUser(User user)
    {
        
    }

    public IEnumerable<User> GetAllUsers()
    {
        try
        {
            var data = File.ReadAllText(FileName);
            var result = JsonConvert.DeserializeObject<IEnumerable<User>>(data);

            return result ?? Enumerable.Empty<User>();
        }
        catch
        {
            return Enumerable.Empty<User>();
        }
    }
}