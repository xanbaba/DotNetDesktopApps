using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
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
        _view.SaveAsRequested += ViewOnSaveAsRequested;
        _view.SaveAsReceived += ViewOnSaveAsReceived;
        _view.SaveRequested += ViewOnSaveRequested;
        _view.GoToLineRequested += ViewOnGoToLineRequested;
    }

    private void ViewOnGoToLineRequested()
    {
        _view.ShowGoToLineView();
    }

    private void ViewOnSaveAsReceived(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return;
        }
        if (Path.GetExtension(fileName) == ".xpad")
        {
            _view.SaveStyledContentToFile(fileName);
            ViewOnOpenedDocumentReceived(fileName);
        }
        else
        {
            var fileWriter = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            var streamWriter = new StreamWriter(fileWriter);
            streamWriter.Write(_view.TextContent);
            fileWriter.Close();
            ViewOnOpenedDocumentReceived(fileName);
        }
    }

    private void ViewOnSaveRequested()
    {
        if (_document == null)
        {
            ViewOnSaveAsRequested();
            return;
        }

        if (Path.GetExtension(_document.FileName) == ".xpad")
        {
            _view.SaveStyledContentToFile(_document.FileName);
            return;
        }
        var streamWriter = new StreamWriter(_document.FileName);
        streamWriter.Write(_view.TextContent);
        streamWriter.Close();
    }

    private void ViewOnSaveAsRequested()
    {
        _view.SaveAsDocument();
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
                _view.LoadStyledContentFromFile(fileName);
                break;
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