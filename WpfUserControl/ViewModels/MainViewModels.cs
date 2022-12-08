using System;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfUserControl.ViewModels;

public partial class MainViewModels : ObservableObject
{
    [ObservableProperty] private string? _myText;

    [ObservableProperty]
    private string? _imagePath = @"C:\Users\yanzh\Desktop\ElPhotos\pexels-nikita-nikitin-8196885.jpg";

    [ObservableProperty] [NotifyPropertyChangedFor(nameof(Width))] [NotifyPropertyChangedFor(nameof(Height))]
    private Point _start;

    [ObservableProperty] [NotifyPropertyChangedFor(nameof(Width))] [NotifyPropertyChangedFor(nameof(Height))]
    private Point _end;

    public double Width => Math.Abs(End.X - Start.X);
    public double Height => Math.Abs(End.Y - Start.Y);

    // private bool _isMounsedown = false;
    
    [ObservableProperty] private double _zoomLevel = 1;


    [RelayCommand]
    public void MouseWheel(MouseWheelEventArgs e)
    {
        
        
        ZoomLevel += e.Delta/1200.0;
        if (ZoomLevel < 0.1) ZoomLevel = 0.1;
    }
    
    

    [RelayCommand]
    public void MouseDown(MouseEventArgs e)
    {
        if (e.LeftButton != MouseButtonState.Pressed) return;
        Start = End = e.GetPosition(e.Source as IInputElement);
    }

    [RelayCommand]
    public void MouseMove(MouseEventArgs e)
    {
        if (e.LeftButton != MouseButtonState.Pressed) return;
        var point = e.GetPosition(e.Source as IInputElement);
        Start = new Point(Math.Min(Start.X, point.X), Math.Min(Start.Y, point.Y));
        End = new Point(Math.Max(point.X, End.X), Math.Max(point.Y, End.Y));
        MyText = $"Width: {Width}, Height: {Height}";
    }


    [RelayCommand(CanExecute = nameof(CanShowWelcomeDialog))]
    public void ShowWelcomeDialog(EventArgs? e = null)
    {
        if (e is null) return;
        MyText += "Welcome to the MVVM Toolkit!\n";
        MessageBox.Show(e.GetType().FullName);
    }


    public bool CanShowWelcomeDialog(EventArgs? e = null)
    {
        return true;
    }
}