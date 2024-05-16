using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FastTyper;

public class MainWindowPresenter
{
    private const string WordsFileName = "words.json";

    private readonly MainWindow _mainWindow;

    public MainWindowPresenter(MainWindow mainWindow)
    {
        _mainWindow = mainWindow;
        _mainWindow.NewWordShowed += StopTyping;
        _mainWindow.WordCompleted += MainWindowOnWordCompleted;
        _mainWindow.OnStartClicked += StartTyping;
        _mainWindow.OnStopClicked += StopTyping;
        _words = LoadWords();
    }

    private void MainWindowOnWordCompleted()
    {
        StopTyping();
        ++_wordsCount;
        var random = new Random();
        SetNewWord(random);
    }

    private DateTime _startTime;
    private DateTime _stopTime;

    private bool _isCaseSensitive;

    private Difficulty _difficulty;

    private int _wordsCount;

    private Words _words;

    private Words LoadWords()
    {
        return JsonSerializer.Deserialize<Words>(File.ReadAllText(WordsFileName))!;
    }

    private void StartTyping(Difficulty difficulty, bool isCaseSensitive)
    {
        _isCaseSensitive = isCaseSensitive;
        _difficulty = difficulty;
        _startTime = DateTime.Now;
        var random = new Random();
        _wordsCount = 0;
        SetNewWord(random);
    }

    private void SetNewWord(Random random)
    {
        string word;
        switch (_difficulty)
        {
            case Difficulty.Easy:
                word = _words.Easy[random.Next(0, _words.Easy.Count - 1)];
                break;
            case Difficulty.Medium:
                word = _words.Medium[random.Next(0, _words.Medium.Count)];
                break;
            case Difficulty.Hard:
                word = _words.Hard[random.Next(0, _words.Hard.Count)];
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        if (_isCaseSensitive)
        {
            word = char.ToUpper(word[0]) + word[1..];
        }
        _mainWindow.SetNewWord(word);
    }

    private void StopTyping()
    {
        _stopTime = DateTime.Now;
        _mainWindow.SetTypingSpeed(GetTypingSpeed());
    }

    private int GetTypingSpeed()
    {
        int wordLength;
        switch (_difficulty)
        {
            case Difficulty.Easy:
                wordLength = 5;
                break;
            case Difficulty.Medium:
                wordLength = 10;
                break;
            case Difficulty.Hard:
                wordLength = 15;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return (int)(wordLength * _wordsCount / (_stopTime - _startTime).TotalMinutes);
    }
    
}