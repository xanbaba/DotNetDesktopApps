using MVPPattern.Models;
using MVPPattern.Views.Interfaces;

namespace MVPPattern.Views.Windows;

public partial class AddView : Form, IAddView
{
    public AddView()
    {
        InitializeComponent();
    }

    public string Login => loginTextBox.Text;
    public string Password => passwordTextBox.Text;
    
    public event Action? CancelClicked;
    public event Action<User>? AddClicked;
    
    
    public void CloseView()
    {
        Close();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        AddClicked?.Invoke(new User
        {
            Login = Login,
            Password = Password
        });
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        CancelClicked?.Invoke();
    }
}