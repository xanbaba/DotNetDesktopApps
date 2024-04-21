using System;

namespace XanPadPlusPlus.Views.Interfaces;

public interface IGoToLineView
{
    public event Action<int> SubmitClicked;
}