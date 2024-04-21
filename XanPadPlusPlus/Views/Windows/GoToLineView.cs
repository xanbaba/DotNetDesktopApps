using System;
using System.Windows.Forms;
using XanPadPlusPlus.Views.Interfaces;

namespace XanPadPlusPlus.Views.Windows;

public partial class GoToLineView : Form, IGoToLineView
{
    public GoToLineView()
    {
        InitializeComponent();
    }

    public event Action<int>? SubmitClicked;

    private void submitButton_Click(object sender, EventArgs e)
    {
        SubmitClicked?.Invoke((int)valueNumericUpDown.Value);
        Close();
    }
}