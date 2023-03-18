using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MoveItemException
{
    internal partial class ItemsViewModel : ObservableObject
    {
        public void AddItem(string text)
        {
            Items.Add(new ItemViewItem(new Item(text), this));
        }

        public ItemsViewModel()
        {
            AddItem("Item 1");
            AddItem("Item 2");
            AddItem("Item 3");
        }

        public ObservableCollection<ItemViewItem> Items { get; } = new();

        public void CheckstateUpdated(ItemViewItem itemViewItem)
        {
            var currentIndex = Items.IndexOf(itemViewItem);
            var newIndex = itemViewItem.Checked ? Items.Count - 1 : 0;
            Items.Remove(itemViewItem);
            Items.Add(itemViewItem);
        }
    }
}
