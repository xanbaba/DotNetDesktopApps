using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XanTranslate.Models;
using XanTranslate.Views.Interfaces;

namespace XanTranslate.Views.Windows;

public partial class MainView : Form, IMainView
{
    public event Action<TranslationText, TranslationLanguage>? TranslateButtonClicked;

    public MainView()
    {
        InitializeComponent();

        CentralizeControl(translateButton);
        CentralizeControl(reverseButton);
    }

    public void SetLanguagesList(IList<TranslationLanguage> languages)
    {
        sourceLanguageComboBox.DataSource =
            new BindingList<TranslationLanguage>(languages.Prepend(new TranslationLanguage("Auto", "auto")).ToList());
        destinationLanguageComboBox.DataSource = new BindingList<TranslationLanguage>(languages);
    }

    public void SetResultText(string text)
    {
        destinationLanguageTextBox.Text = text;
    }

    private static void CentralizeControl(Control control)
    {
        control.Location =
            new Point(control.Parent.Width / 2 - control.Size.Width / 2,
                control.Parent.Height / 2 - control.Size.Height / 2);

        control.Anchor = AnchorStyles.None;
    }

    private void translateButton_Click(object sender, EventArgs e)
    {
        TranslateButtonClicked?.Invoke(
            new TranslationText(sourceLanguageTextBox.Text, (TranslationLanguage)sourceLanguageComboBox.SelectedItem),
            (TranslationLanguage)destinationLanguageComboBox.SelectedItem);
    }

    private void reverseButton_Click(object sender, EventArgs e)
    {
        if (sourceLanguageComboBox.SelectedIndex == 0)
        {
            return;
        }

        (sourceLanguageComboBox.SelectedItem, destinationLanguageComboBox.SelectedItem) = (
            destinationLanguageComboBox.SelectedItem, sourceLanguageComboBox.SelectedItem);
    }
}