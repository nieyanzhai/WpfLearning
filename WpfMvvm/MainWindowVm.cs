
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfMvvm;

public partial class MainWindowVm : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Welcome))]
    private string name = "";

    public string Welcome => "Hello" + Name;

    [RelayCommand]
    public void Refresh()
    {
        Name = Name;
    }
}