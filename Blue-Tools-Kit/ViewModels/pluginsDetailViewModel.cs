using Blue_Tools_Kit.Contracts.ViewModels;
using Blue_Tools_Kit.Core.Contracts.Services;
using Blue_Tools_Kit.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace Blue_Tools_Kit.ViewModels;

public partial class pluginsDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public pluginsDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
