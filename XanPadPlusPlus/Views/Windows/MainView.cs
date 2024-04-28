using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using XanPadPlusPlus.Models;
using XanPadPlusPlus.Services.Interfaces;
using XanPadPlusPlus.Views.Interfaces;

namespace XanPadPlusPlus.Views.Windows;

public partial class MainView : Form, IMainView
{
    private readonly ISystem _system;

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
    public event Action? SaveAsRequested;
    public event Action<string>? SaveAsReceived;
    public event Action? SaveRequested;
    public event Action? GoToLineRequested;

    public MainView(ISystem system)
    {
        _system = system;
        InitializeComponent();

        textBox.SelectionChanged += (_, _) => { CaretPositionIndicatorModified?.Invoke(); };
    }

    public void CapsLockIndicatorModify()
    {
        capsLockToolStripStatusLabel.Text = string.Format(CapsLockStateFormat,
            _system.GetCapsLockStatus() ? "On" : "Off");
    }

    public void SelectedLanguageIndicatorModify()
    {
        selectedLangToolStripStatusLabel.Text =
            string.Format(SelectedLanguageFormat, _system.GetSelectedLanguage());
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

    public void SaveAsDocument()
    {
        using var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = @"xpad files (*.xpad)|*.xpad|txt files (*.txt)|*.txt|All files (*.*)|*.*";
        saveFileDialog.OverwritePrompt = true;
        saveFileDialog.ShowDialog();
        SaveAsReceived?.Invoke(saveFileDialog.FileName);
    }

    public string TextContent => textBox.Text;
    public void SaveStyledContentToFile(string filePath)
    {
        textBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
    }

    public void LoadStyledContentFromFile(string filePath)
    {
        textBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
    }

    public void ImportDataFromDocumentData(string documentData)
    {
        textBox.Text = documentData;
    }

    public void ShowGoToLineView()
    {
        var goToLineView = new GoToLineView();
        goToLineView.SubmitClicked += GoToLineViewOnSubmitClicked;
        goToLineView.ShowDialog();
    }

    private void GoToLineViewOnSubmitClicked(int line)
    {
        if (line < 1 || line > textBox.Text.Split('\n').Length)
        {
            return;
        }

        textBox.SelectionStart = textBox.GetFirstCharIndexFromLine(line - 1);
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

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveRequested?.Invoke();
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveAsRequested?.Invoke();
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        textBox.Cut();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        textBox.Copy();
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        textBox.Paste();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        textBox.Text = textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength);
    }

    private void goToolStripMenuItem_Click(object sender, EventArgs e)
    {
        GoToLineRequested?.Invoke();
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
        textBox.SelectAll();
    }

    private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
    {
        textBox.Text = textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength)
            .Insert(textBox.SelectionStart, _system.GetTimeDate());
    }

    private void fontToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var fontDialog = new FontDialog();
        fontDialog.ShowDialog();

        if (textBox.SelectionLength != 0)
        {
            textBox.SelectionFont = fontDialog.Font;
        }
        else
        {
            textBox.Font = fontDialog.Font;
        }
    }

    private void colorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var colorDialog = new ColorDialog();
        colorDialog.ShowDialog();
        if (textBox.SelectionLength != 0)
        {
            textBox.SelectionColor = colorDialog.Color;
        }
        else
        {
            textBox.ForeColor = colorDialog.Color;
        }
    }
}