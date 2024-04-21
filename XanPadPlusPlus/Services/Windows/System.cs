using System;
using System.Globalization;
using System.Windows.Forms;

namespace XanPadPlusPlus.Services.Windows;

public static class System
{
    public static bool GetCapsLockStatus()
    {
        return Control.IsKeyLocked(Keys.CapsLock);
    }

    public static string GetSelectedLanguage()
    {
        return InputLanguage.CurrentInputLanguage.Culture.Name;
    }
}