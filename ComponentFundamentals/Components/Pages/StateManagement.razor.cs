using ComponentFundamentals.Components.Services;

namespace ComponentFundamentals.Components.Pages;

/// <summary>
/// This demo demonstrates state management using the component itself.
/// </summary>
public partial class StateManagement : IAsyncDisposable
{
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
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
