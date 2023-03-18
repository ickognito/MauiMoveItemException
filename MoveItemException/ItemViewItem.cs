using CommunityToolkit.Mvvm.ComponentModel;

namespace MoveItemException;

internal class ItemViewItem : ObservableObject
{
    private readonly Item _item;
    private readonly ItemsViewModel _viewModel;

    public ItemViewItem(Item item, ItemsViewModel viewModel)
    {
        _item = item;
        _viewModel = viewModel;
    }

    public bool Checked
    {
        get => _item.Checked;
        set
        {
            if (_item.Checked == value)
            {
                return;
            }
            _item.Checked = value;
            _viewModel.CheckstateUpdated(this);
            OnPropertyChanged();
        }
    }
    public string Name
    {
        get => _item.Name;
        set
        {
            if (_item.Name == value)
            {
                return;
            }
            _item.Name = value;
            OnPropertyChanged();
        }
    }
}