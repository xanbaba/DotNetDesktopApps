using System;
using System.IO;
using XanPadPlusPlus.Models;
using XanPadPlusPlus.Views.Interfaces;

namespace XanPadPlusPlus.Presenters;

public class MainPresenter
{
    private readonly IMainView _view;

    // Opened document
    private Document? _document;

    public MainPresenter(IMainView view)
    {
        _view = view;

        _view.CapsLockIndicatorModified += ViewOnCapsLockIndicatorModified;
        _view.SelectedLanguageIndicatorModified += ViewOnSelectedLanguageIndicatorModified;
        _view.CaretPositionIndicatorModified += ViewOnCaretPositionIndicatorModified;
        _view.LinesCountIndicatorModified += ViewOnLinesCountIndicatorModified;
        _view.NewPadRequested += ViewOnNewPadRequested;
        _view.OpenDocumentRequested += ViewOnOpenDocumentRequested;
        _view.OpenedDocumentReceived += ViewOnOpenedDocumentReceived;
    }

    private void ViewOnOpenedDocumentReceived(string fileName)
    {
        if (fileName == string.Empty)
        {
            return;
        }

        _document = new Document
        {
            FileName = fileName
        };
        var extension = Path.GetExtension(fileName);
        switch (extension)
        {
            case null:
            case ".txt":
                _view.ImportDataFromDocumentData(File.ReadAllText(fileName));
                break;
            case ".xpad":
                throw new NotImplementedException();
        }
    }

    private void ViewOnOpenDocumentRequested()
    {
        _view.OpenDocument();
    }

    private void ViewOnNewPadRequested()
    {
        _view.OpenNewPad();
    }

    private void ViewOnLinesCountIndicatorModified()
    {
        _view.LinesCountIndicatorModify();
    }

    private void ViewOnCaretPositionIndicatorModified()
    {
        _view.CaretPositionIndicatorModify();
    }

    private void ViewOnSelectedLanguageIndicatorModified()
    {
        _view.SelectedLanguageIndicatorModify();
    }

    private void ViewOnCapsLockIndicatorModified()
    {
        _view.CapsLockIndicatorModify();
    }
}