using Blue_Tools_Kit.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Blue_Tools_Kit.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class textPage : Page
{
    public textViewModel ViewModel
    {
        get;
    }

    public textPage()
    {
        ViewModel = App.GetService<textViewModel>();
        InitializeComponent();
    }
}
