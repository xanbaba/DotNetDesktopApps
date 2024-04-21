global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Windows.Forms;
using MVPPattern.Presenters;
using MVPPattern.Views.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace MVPPattern;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var serviceCollection = new ServiceCollection();
        
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var mainView = new MainView();
        _ = new MainPresenter(mainView);
        
        Application.Run(mainView);
    }
}