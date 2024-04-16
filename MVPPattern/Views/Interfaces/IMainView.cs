using MVPPattern.Models;
namespace MVPPattern.Views.Interfaces;

public interface IMainView
{
    event Action AddClicked;
    event Action<User> UpdateClicked;
    event Action<User> RemoveClicked;
    event Action<User> UserReceived; 

    void ShowAddView();
    void AddUser(User user);
    void RemoveUser(User user);
}