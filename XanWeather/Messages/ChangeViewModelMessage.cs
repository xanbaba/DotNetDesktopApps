using XanWeather.ViewModels;

namespace XanWeather.Messages;

public class ChangeViewModelMessage(BaseViewModel baseViewModel)
{
    public BaseViewModel BaseViewModel { get; init; } = baseViewModel;
}