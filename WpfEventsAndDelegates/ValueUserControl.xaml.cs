using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfEventsAndDelegates;

public partial class ValueUserControl : UserControl
{
    public delegate void ValueChangedEventHandler(object sender, EventArgs e);
    public event ValueChangedEventHandler ValueChanged;
    
    
    public ValueUserControl()
    {
        InitializeComponent();
    }

    private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
    {
        TBValue.Text = (int.Parse(TBValue.Text) + 10).ToString();
    }

    private void BtnSub_OnClick(object sender, RoutedEventArgs e)
    {
        TBValue.Text = (int.Parse(TBValue.Text) - 10).ToString();
    }

    private void TBValue_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        TBValue.Text = int.Parse(TBValue.Text) switch
        {
            > 100 => "100",
            < 0 => "0",
            _ => TBValue.Text
        };
        ValueChanged?.Invoke(this, e);
    }
}