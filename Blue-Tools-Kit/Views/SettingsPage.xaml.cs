using Blue_Tools_Kit.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Windows.Globalization;

namespace Blue_Tools_Kit.Views;

// TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
public sealed partial class SettingsPage : Page
{
    public SettingsViewModel ViewModel
    {
        get;
    }

    public languageViewModel LanguageViewModel { get; }

    public SettingsPage()
    {
        
        ApplicationLanguages.PrimaryLanguageOverride = "zh-CN";
        
        ViewModel = App.GetService<SettingsViewModel>();
        InitializeComponent();
    }

    
}
