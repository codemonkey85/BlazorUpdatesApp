using Microsoft.AspNetCore.Components;

namespace BlazorUpdates.Pages;

public partial class Counter
{
    [Parameter]
    [SupplyParameterFromQuery(Name = "count")]
    public int CurrentCount { get; set; } = 0;

    private void IncrementCount()
    {
        throw new Exception("This was a mistake");
        CurrentCount += 1;
    }
}
