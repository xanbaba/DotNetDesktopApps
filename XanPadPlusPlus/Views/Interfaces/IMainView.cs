using System;
using System.IO;
using XanPadPlusPlus.Models;

namespace XanPadPlusPlus.Views.Interfaces;

public interface IMainView
{
    // Indicator events
    event Action CapsLockIndicatorModified;
    event Action SelectedLanguageIndicatorModified;
    event Action CaretPositionIndicatorModified;
    event Action LinesCountIndicatorModified;

    // Indicator methods
    void CapsLockIndicatorModify();
    void SelectedLanguageIndicatorModify();
    void CaretPositionIndicatorModify();
    void LinesCountIndicatorModify();


    // File section events
    event Action NewPadRequested;
    event Action OpenDocumentRequested;
    event Action<string> OpenedDocumentReceived;
    event Action SaveAsRequested;
    event Action<string> SaveAsReceived;
    event Action SaveRequested; 

    // File section methods
    void OpenNewPad();
    void OpenDocument();
    void ImportDataFromDocumentData(string documentData);
    public void SaveAsDocument();

    // Edit Section methods & events
    public void ShowGoToLineView();
    public event Action GoToLineRequested;

    
    // Text box content
    public string TextContent { get; }

    CaretPosition GetCaretPosition();
}