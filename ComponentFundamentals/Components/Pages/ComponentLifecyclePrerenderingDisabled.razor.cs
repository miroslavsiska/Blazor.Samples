namespace ComponentFundamentals.Components.Pages;


/// <summary>
/// This demo demonstrates the component lifecycle with prerendering disabled.
/// </summary>
public partial class ComponentLifecyclePrerenderingDisabled // : ComponentBase, IAsyncDisposable
{
    private int currentCount = 0;
    private void IncrementCount()
    {
        Console.WriteLine("Clicked...................");
        currentCount++;
    }

    protected override bool ShouldRender()
    {
        Console.WriteLine($"ShouldRender: {base.ShouldRender()}");
        return base.ShouldRender();
    }

    protected override void OnInitialized()
    {
        Console.WriteLine($"OnInitialized => IsInteractive:{RendererInfo.IsInteractive}");
        base.OnInitialized();
    }

    protected override Task OnInitializedAsync()
    {
        Console.WriteLine($"OnInitializedAsync => IsInteractive:{RendererInfo.IsInteractive}");
        return base.OnInitializedAsync();
    }


    protected override void OnParametersSet()
    {
        Console.WriteLine($"OnParametersSet => IsInteractive:{RendererInfo.IsInteractive}");
        base.OnParametersSet();
    }

    protected override Task OnParametersSetAsync()
    {
        Console.WriteLine($"OnParametersSetAsync => IsInteractive:{RendererInfo.IsInteractive}");
        return base.OnParametersSetAsync();
    }


    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine($"OnAfterRender => IsInteractive:{RendererInfo.IsInteractive}, firstRender: {firstRender}");
        base.OnAfterRender(firstRender);
    }
    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine($"OnAfterRenderAsync => IsInteractive:{RendererInfo.IsInteractive}, firstRender: {firstRender}, ");
        return base.OnAfterRenderAsync(firstRender);
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
