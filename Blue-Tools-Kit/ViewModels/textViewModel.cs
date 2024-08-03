using System.Collections.ObjectModel;

using Blue_Tools_Kit.Contracts.ViewModels;
using Blue_Tools_Kit.Core.Contracts.Services;
using Blue_Tools_Kit.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace Blue_Tools_Kit.ViewModels;

public partial class textViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public textViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
