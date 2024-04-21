using System;
using System.Windows.Forms;
using XanPadPlusPlus.Services.Interfaces;

namespace XanPadPlusPlus.Services.Windows;

public class System : ISystem
{
    public bool GetCapsLockStatus()
    {
        return Control.IsKeyLocked(Keys.CapsLock);
    }

    public string GetSelectedLanguage()
    {
        return InputLanguage.CurrentInputLanguage.Culture.Name;
    }

    public string GetTimeDate()
    {
        var dateTime = DateTime.Now;
        return dateTime.ToShortTimeString() + ' ' + dateTime.ToShortDateString();
    }
}