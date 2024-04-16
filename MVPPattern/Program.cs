global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Windows.Forms;
using MVPPattern.Presenters;
using MVPPattern.Views.Windows;

namespace MVPPattern;

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