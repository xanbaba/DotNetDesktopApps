using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanPadPlusPlus.Presenters;
using XanPadPlusPlus.Views.Windows;

namespace XanPadPlusPlus;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var mainView = new MainView();
        _ = new MainPresenter(mainView);

        Application.Run(mainView);
    }
}