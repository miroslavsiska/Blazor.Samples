using Microsoft.AspNetCore.Components;

namespace ComponentFundamentals.Components.Pages;

/// <summary>
/// The component binding sample.
/// </summary>
public partial class BindingParameterComponent : IAsyncDisposable //: ComponentBase, IAsyncDisposable 
{
    /// <summary>
    /// The count.
    /// </summary>
    [Parameter] public int Count { get; set; }


    #region For_information
    /// <inheritdoc />
    protected override bool ShouldRender()
    {
        Console.WriteLine($"ShouldRender: {base.ShouldRender()}");
        return base.ShouldRender();
    }

    /// <inheritdoc />
    protected override void OnInitialized()
    {
        Console.WriteLine($"OnInitialized");
        base.OnInitialized();
    }
    /// <inheritdoc />
    protected override Task OnInitializedAsync()
    {
        Console.WriteLine($"OnInitializedAsync");
        return base.OnInitializedAsync();
    }


    /// <inheritdoc />
    protected override void OnParametersSet()
    {
        Console.WriteLine($"OnParametersSet");
        base.OnParametersSet();
    }
    /// <inheritdoc />
    protected override Task OnParametersSetAsync()
    {
        Console.WriteLine($"OnParametersSetAsync");
        return base.OnParametersSetAsync();
    }


    /// <inheritdoc />
    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine($"OnAfterRender, firstRender: {firstRender}");
        base.OnAfterRender(firstRender);
    }
    /// <inheritdoc />
    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine($"OnAfterRenderAsync, firstRender: {firstRender}, ");
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
    #endregion

}