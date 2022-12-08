using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfUserControl.UserControls;

public partial class WelcomeUserControl : UserControl
{
    public static readonly DependencyProperty WelcomeTextProperty = DependencyProperty.Register(
        nameof(WelcomeText), typeof(string), typeof(WelcomeUserControl), new PropertyMetadata("Welcome"));

    public string WelcomeText
    {
        get => (string)GetValue(WelcomeTextProperty);
        set => SetValue(WelcomeTextProperty, value);
    }

    public static readonly DependencyProperty ShowMessageCommandProperty = DependencyProperty.Register(
        nameof(ShowMessageCommand), typeof(ICommand), typeof(WelcomeUserControl), new PropertyMetadata(default(ICommand)));

    public ICommand ShowMessageCommand
    {
        get => (ICommand)GetValue(ShowMessageCommandProperty);
        set => SetValue(ShowMessageCommandProperty, value);
    }

    public WelcomeUserControl()
    {
        InitializeComponent();
    }
}