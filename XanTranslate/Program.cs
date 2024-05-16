using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using XanTranslate.Presenters;
using XanTranslate.Services;
using XanTranslate.Services.YandexApiTranslator;
using XanTranslate.Views.Interfaces;
using XanTranslate.Views.Windows;

namespace XanTranslate
{
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

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IMainView, MainView>();
            serviceCollection.AddSingleton<MainViewPresenter>();
            serviceCollection.AddTransient<ITranslator, YandexApiTranslator>();

            var provider = serviceCollection.BuildServiceProvider();

            var mainView = provider.GetService(typeof(IMainView));
            provider.GetService(typeof(MainViewPresenter));
            Application.Run((MainView?)mainView ?? null);
            
        }
    }
}