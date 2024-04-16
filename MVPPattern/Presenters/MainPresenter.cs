using MVPPattern.Models;
using MVPPattern.Views.Interfaces;

namespace MVPPattern.Presenters;

public class MainPresenter
{
    private readonly IMainView _mainView;
    
    public MainPresenter(IMainView mainView)
    {
        _mainView = mainView;

        _mainView.AddClicked += ViewOnAddClicked;
        _mainView.RemoveClicked += ViewOnRemoveClicked;
        _mainView.UpdateClicked += ViewOnUpdateClicked;
        _mainView.UserReceived += MainViewOnUserReceived;
    }

    private void MainViewOnUserReceived(User user)
    {
        _mainView.AddUser(user);
    }

    private void ViewOnUpdateClicked(User obj)
    {
        throw new NotImplementedException();
    }

    private void ViewOnRemoveClicked(User user)
    {
        _mainView.RemoveUser(user);
    }

    private void ViewOnAddClicked()
    {
        _mainView.ShowAddView();
    }
}