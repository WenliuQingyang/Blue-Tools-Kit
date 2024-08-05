using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Windows.Globalization;

namespace Blue_Tools_Kit.ViewModels;

public partial class languageViewModel : ObservableObject
{
    [ObservableProperty]
    private string _language;

    public string SwitchLanguageCommand
    {
        get;
    }

    [RelayCommand]
    void ChangeLang()
    {
        if (SwitchLanguageCommand == "English")
        {
            ApplicationLanguages.PrimaryLanguageOverride = "en-US";
        }
    }
}
