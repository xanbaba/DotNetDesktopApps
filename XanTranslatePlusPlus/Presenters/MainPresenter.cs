using XanTranslatePlusPlus.Views.Interfaces;

namespace XanTranslatePlusPlus.Presenters;

public class MainPresenter
{
    private readonly IMainView _view;

    public MainPresenter(IMainView view)
    {
        _view = view;
    }
}