using Blue_Tools_Kit.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace Blue_Tools_Kit.Views;

public sealed partial class Blue_TalkPage : Page
{
    public Blue_TalkViewModel ViewModel
    {
        get;
    }

    public Blue_TalkPage()
    {
        ViewModel = App.GetService<Blue_TalkViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
