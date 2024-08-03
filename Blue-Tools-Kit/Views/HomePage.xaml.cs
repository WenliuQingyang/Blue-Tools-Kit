using Blue_Tools_Kit.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Blue_Tools_Kit.Views;

public sealed partial class HomePage : Page
{
    public HomeViewModel ViewModel
    {
        get;
    }

    public HomePage()
    {
        ViewModel = App.GetService<HomeViewModel>();
        InitializeComponent();
    }
}
