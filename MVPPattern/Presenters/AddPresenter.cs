using MVPPattern.Models;
using MVPPattern.Views.Interfaces;

namespace MVPPattern.Presenters;

public class AddPresenter
{
    private readonly IAddView _addView;

    public AddPresenter(IAddView addView)
    {
        _addView = addView;
        
        _addView.AddClicked += ViewOnAddClicked;
        _addView.CancelClicked += ViewOnCancelClicked;
    }

    private void ViewOnCancelClicked()
    {
        _addView.CloseView();
    }

    private void ViewOnAddClicked(User user)
    {
        _addView.CloseView();
    }
}