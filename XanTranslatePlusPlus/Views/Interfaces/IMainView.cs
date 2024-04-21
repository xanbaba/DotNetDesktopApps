using System;

namespace XanTranslatePlusPlus.Views.Interfaces;

public interface IMainView
{
    public event Action ReverseButtonClicked;
    public event Action TranslateButtonClicked;
}