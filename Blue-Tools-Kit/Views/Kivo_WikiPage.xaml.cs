using Blue_Tools_Kit.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Blue_Tools_Kit.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class Kivo_WikiPage : Page
{
    public Kivo_WikiViewModel ViewModel
    {
        get;
    }

    public Kivo_WikiPage()
    {
        
        ViewModel = App.GetService<Kivo_WikiViewModel>();
        InitializeComponent();
        
        ViewModel.WebViewService.Initialize(WebView);
    }

    private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        
    }
}
