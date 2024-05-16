using Microsoft.Extensions.DependencyInjection;
using XanWeather.ViewModels;

namespace XanWeather.Services;

public class ViewModelFactory
{
    public BaseViewModel Create<TViewModel>() where TViewModel : BaseViewModel
    {
        var viewModel = App.ServiceProvider.GetService<TViewModel>();

        if (viewModel == null)
        {
            throw new ApplicationException($"Service provider does not have provided ViewModel: {typeof(TViewModel)}");
        }
        
        return viewModel;
    }
}