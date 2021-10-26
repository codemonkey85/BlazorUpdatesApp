using Microsoft.AspNetCore.Components;

namespace BlazorUpdates.Shared;

public partial class SurveyPrompt
{
    [Parameter]
    public string? Title { get; set; }
}
