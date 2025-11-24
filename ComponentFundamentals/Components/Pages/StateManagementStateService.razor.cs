using ComponentFundamentals.Components.Services;
using Microsoft.AspNetCore.Components;

namespace ComponentFundamentals.Components.Pages;

/// <summary>
/// This demo demonstrates state management using the state service.
/// </summary>
public partial class StateManagementStateService : IAsyncDisposable
{
    /// <summary>
    /// The state service.
    /// </summary>
    [Inject] private StateService _stateService { get; set; } = default!;

    //public StateManagementStateService(StateService state)
    //{
    //    _state = state;
    //}

    private void IncrementCount()
    {
        _stateService.Count++;
    }

    public async ValueTask DisposeAsync()
    {
        await DisposeAsyncCore();
        GC.SuppressFinalize(this);
    }
    protected virtual ValueTask DisposeAsyncCore()
    {
        Console.WriteLine($"Component has been disposed");
        return ValueTask.CompletedTask;
    }
}
