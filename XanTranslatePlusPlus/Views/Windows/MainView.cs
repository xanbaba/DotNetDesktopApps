using System;
using System.Drawing;
using System.Windows.Forms;
using XanTranslatePlusPlus.Views.Interfaces;

namespace XanTranslatePlusPlus.Views.Windows;

public partial class MainView : Form, IMainView
{
    public event Action? ReverseButtonClicked;
    public event Action? TranslateButtonClicked;

    public MainView()
    {
        InitializeComponent();

        CentralizeControl(translateButton);
        CentralizeControl(reverseButton);
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
        TranslateButtonClicked?.Invoke();
    }

    private void reverseButton_Click(object sender, EventArgs e)
    {
        ReverseButtonClicked?.Invoke();
    }
}