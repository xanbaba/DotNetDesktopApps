using MVPPattern.Models;
using MVPPattern.Presenters;
using MVPPattern.Views.Interfaces;

namespace MVPPattern.Views.Windows;

public partial class MainView : Form, IMainView
{
    public MainView()
    {
        InitializeComponent();
    }

    public event Action? AddClicked;
    public event Action<User>? UpdateClicked;
    public event Action<User>? RemoveClicked;
    public event Action<User>? UserReceived;

    public void ShowAddView()
    {
        var view = new AddView();
        _ = new AddPresenter(view);

        view.AddClicked += user =>
        {
            UserReceived?.Invoke(user);
        };
        view.ShowDialog();
    }

    public void AddUser(User user)
    {
        usersListBox.Items.Add(user);
    }

    public void RemoveUser(User user)
    {
        usersListBox.Items.Remove(user);
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        AddClicked?.Invoke();
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        UpdateClicked?.Invoke((User)usersListBox.SelectedItem);
    }

    private void removeButton_Click(object sender, EventArgs e)
    {
        RemoveClicked?.Invoke((User)usersListBox.SelectedItem);
    }
}