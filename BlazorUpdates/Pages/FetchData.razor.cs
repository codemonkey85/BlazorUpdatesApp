using BlazorUpdates.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorUpdates.Pages;

public partial class FetchData
{
    [Inject]
    WeatherForecastService? ForecastService { get; set; }

    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync() => forecasts = ForecastService == null ? null : await ForecastService.GetForecastAsync(DateTime.Now);
}
