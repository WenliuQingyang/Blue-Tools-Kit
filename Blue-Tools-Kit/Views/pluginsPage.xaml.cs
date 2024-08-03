using Blue_Tools_Kit.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Blue_Tools_Kit.Views;

public sealed partial class pluginsPage : Page
{
    public pluginsViewModel ViewModel
    {
        get;
    }

    public pluginsPage()
    {
        ViewModel = App.GetService<pluginsViewModel>();
        InitializeComponent();
    }
}
