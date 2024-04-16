using MVPPattern.Models;

namespace MVPPattern.Views.Interfaces;

public interface IAddView
{
    string Login { get; }
    string Password { get; }
    event Action CancelClicked;
    event Action<User> AddClicked;

    void CloseView();
}