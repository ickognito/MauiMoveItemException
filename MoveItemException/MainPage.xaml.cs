namespace MoveItemException;

public partial class MainPage : ContentPage
{
	public MainPage()
    {
        BindingContext = new ItemsViewModel();
		InitializeComponent();
	}

}

