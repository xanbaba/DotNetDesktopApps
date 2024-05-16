using System;
using System.Collections.Generic;
using System.ComponentModel;
using XanTranslate.Models;

namespace XanTranslate.Views.Interfaces;

public interface IMainView
{
    public event Action<TranslationText, TranslationLanguage> TranslateButtonClicked;

    public void SetLanguagesList(IList<TranslationLanguage> languages);
    public void SetResultText(string text);
}