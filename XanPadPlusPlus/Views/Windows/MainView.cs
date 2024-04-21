using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using XanPadPlusPlus.Models;
using XanPadPlusPlus.Views.Interfaces;

namespace XanPadPlusPlus.Views.Windows;

public partial class MainView : Form, IMainView
{
    private const string CaretPositionFormat = "Ln {0}, Col {1}";
    private const string LinesCountFormat = "Lines count: {0}";
    private const string CapsLockStateFormat = "Caps Lock: {0}";
    private const string SelectedLanguageFormat = "Lang: {0}";
    
    public event Action? CapsLockIndicatorModified;
    public event Action? SelectedLanguageIndicatorModified;
    public event Action? CaretPositionIndicatorModified;
    public event Action? LinesCountIndicatorModified;
    public event Action? NewPadRequested;
    public event Action? OpenDocumentRequested;
    public event Action<string>? OpenedDocumentReceived;

    public MainView()
    {
        InitializeComponent();

        textBox.SelectionChanged += (_, _) => { CaretPositionIndicatorModified?.Invoke(); };
        
    }

    public void CapsLockIndicatorModify()
    {
        capsLockToolStripStatusLabel.Text = string.Format(CapsLockStateFormat,
            Services.Windows.System.GetCapsLockStatus() ? "On" : "Off");
    }

    public void SelectedLanguageIndicatorModify()
    {
        selectedLangToolStripStatusLabel.Text =
            string.Format(SelectedLanguageFormat, Services.Windows.System.GetSelectedLanguage());
    }

    public void CaretPositionIndicatorModify()
    {
        var caretPosition = GetCaretPosition();
        caretPositionToolStripStatusLabel.Text =
            string.Format(CaretPositionFormat, caretPosition.Line, caretPosition.Col);
    }

    public void LinesCountIndicatorModify()
    {
        linesCountToolStripStatusLabel.Text = string.Format(LinesCountFormat, textBox.Text.Split('\n').Length);
    }

    public void OpenNewPad()
    {
        Process.Start(Assembly.GetCallingAssembly().GetName().Name + ".exe");
    }

    public void OpenDocument()
    {
        using var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"xpad files (*.xpad)|*.xpad|txt files (*.txt)|*.txt|All files (*.*)|*.*";
        openFileDialog.ShowDialog();
        OpenedDocumentReceived?.Invoke(openFileDialog.FileName);
    }

    public void ImportDataFromDocumentData(string documentData)
    {
        textBox.Text = documentData;
    }

    public CaretPosition GetCaretPosition()
    {
        var caretLocationIndex = textBox.SelectionStart + textBox.SelectionLength;
        var line = 1;
        var col = 1;
        for (var i = 0; i < caretLocationIndex; i++)
        {
            var symbol = textBox.Text[i];
            if (symbol == '\n')
            {
                ++line;
                col = 0;
            }
            else
            {
                ++col;
            }
        }

        return new CaretPosition
        {
            Line = line,
            Col = col
        };
    }

    private void MainView_Load(object sender, EventArgs e)
    {
        CaretPositionIndicatorModified?.Invoke();
        LinesCountIndicatorModified?.Invoke();
        CapsLockIndicatorModified?.Invoke();
        SelectedLanguageIndicatorModified?.Invoke();
    }

    private void MainView_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.CapsLock)
        {
            CapsLockIndicatorModified?.Invoke();
        }

        SelectedLanguageIndicatorModified?.Invoke();
    }

    private void textBox_FocusChanged(object sender, EventArgs e)
    {
        CapsLockIndicatorModified?.Invoke();
        SelectedLanguageIndicatorModified?.Invoke();
    }

    private void textBox_TextChanged(object sender, EventArgs e)
    {
        LinesCountIndicatorModified?.Invoke();
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        NewPadRequested?.Invoke();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenDocumentRequested?.Invoke();
    }
}