using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Timer = System.Timers.Timer;

namespace FastTyper;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, INotifyPropertyChanged
{
    private int _fails;
    private bool _isCaseSensitive;
    public event Action? NewWordShowed;
    public event Action? WordCompleted;
    public event Action<Difficulty, bool>? OnStartClicked;
    public event Action? OnStopClicked;

    public MainWindow()
    {
        DataContext = this;
        InitializeComponent();
        _ = new MainWindowPresenter(this);
    }

    public int Fails
    {
        get => _fails;
        set => SetField(ref _fails, value);
    }

    public bool IsCaseSensitive
    {
        get => _isCaseSensitive;
        set => SetField(ref _isCaseSensitive, value);
    }

    private void RangeBase_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        Difficulty.Text = ((int)((Slider)sender).Value).ToString(CultureInfo.InvariantCulture);
    }

    private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
    {
    }

    private void KeyBoardButtonPressed(object sender, RoutedEventArgs e)
    {
        if (sender is not Button button) return;
        if (button.Content.ToString() == "Space")
        {
            UserInputTextBox.Text += ' ';
            return;
        }
        UserInputTextBox.Text += button.Content;
        ProcessKeyboardInput();
    }

    private void ProcessKeyboardInput()
    {
        if (UserInputTextBox.Text.Length == WordsTextBox.Text.Length && UserInputTextBox.Text.Length != 0)
        {
            WordCompleted?.Invoke();
            NewWordShowed?.Invoke();
            UserInputTextBox.Text = string.Empty;
        }
    }

    private void StartClicked(object sender, RoutedEventArgs e)
    {
        OnStartClicked?.Invoke((Difficulty)int.Parse(Difficulty.Text), IsCaseSensitive);
    }

    private void StopClicked(object sender, RoutedEventArgs e)
    {
        OnStopClicked?.Invoke();
        WordsTextBox.Text = string.Empty;
        UserInputTextBox.Text = string.Empty;
        Fails = 0;
    }

    public void SetTypingSpeed(int speed)
    {
        TypingSpeed.Text = speed.ToString();
    }

    public void SetNewWord(string word)
    {
        WordsTextBox.Text = word;
        NewWordShowed?.Invoke();
    }

    private void UserInputTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        foreach (var textChange in e.Changes)
        {
            if (textChange.AddedLength > 0)
            {
                try
                {
                    if (IsCaseSensitive)
                    {
                        if (WordsTextBox.Text[textChange.Offset] != UserInputTextBox.Text[textChange.Offset])
                        {
                            Fails += 1;
                        }
                    }
                    else
                    {
                        if (WordsTextBox.Text[textChange.Offset] != char.ToLower(UserInputTextBox.Text[textChange.Offset]))
                        {
                            Fails += 1;
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                }
            }
        }

        ProcessKeyboardInput();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    private void UserInputTextBox_OnKeyDown(object sender, KeyEventArgs e)
    {
        foreach (UIElement keyboardButtonsChild in KeyboardButtons.Children)
        {
            if (keyboardButtonsChild is not Grid keyboardButtonsChildGrid) continue;
            foreach (UIElement keyboardButtonElement in keyboardButtonsChildGrid.Children)
            {
                if (keyboardButtonElement is not Button keyboardButton) continue;
                var key = char.ToLower(e.Key.ToString().First()) + e.Key.ToString()[1..];
                if (keyboardButton.Content.ToString() == key)
                {
                    var indicatingBackground = Color.FromRgb(200, 200, 200);

                    var timer = new Timer();
                    timer.Interval = 200;
                    var oldBack = keyboardButton.Background.Clone();
                    if (keyboardButton.Background is SolidColorBrush)
                    {
                        var colorValue = ((SolidColorBrush)oldBack).Color;
                        if (colorValue == indicatingBackground)
                        {
                            return;
                        }
                    }

                    keyboardButton.Background = new SolidColorBrush(indicatingBackground);
                    timer.Start();
                    timer.AutoReset = false;
                    timer.Elapsed += (_, _) =>
                    {
                        Dispatcher.Invoke(() =>
                        {
                            try
                            {
                                keyboardButton.Background = oldBack;
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                            }
                        });
                    };
                }
            }
        }
    }
}