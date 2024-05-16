using XanTranslate.Models;
using XanTranslate.Services;
using XanTranslate.Views.Interfaces;

namespace XanTranslate.Presenters;

public class MainViewPresenter
{
    private readonly IMainView _mainView;
    private readonly ITranslator _translator;

    public MainViewPresenter(IMainView mainView, ITranslator translator)
    {
        _mainView = mainView;
        _translator = translator;
        MainViewEventSubscribe();
        InitializeMembers();
    }

    private void MainViewEventSubscribe()
    {
        _mainView.TranslateButtonClicked += MainViewOnTranslateButtonClicked;
    }

    private void MainViewOnTranslateButtonClicked(TranslationText translationText, TranslationLanguage translationLanguage)
    {
        if (translationText.TranslationLanguage.Code == "auto")
        {
            _mainView.SetResultText(_translator.Translate(translationText.Text, translationLanguage));
            return;
        }
        _mainView.SetResultText(_translator.Translate(translationText, translationLanguage));
    }

    private void InitializeMembers()
    {
        _mainView.SetLanguagesList(_translator.GetAllLanguages());
    }
}