using CommunityToolkit.Mvvm.ComponentModel;

namespace MoveItemException;

internal partial class Item : ObservableObject
{
    public Item(string name)
    {
        _name = name;
    }

    [ObservableProperty]
    private bool _checked;

    [ObservableProperty]
    private string _name;
}