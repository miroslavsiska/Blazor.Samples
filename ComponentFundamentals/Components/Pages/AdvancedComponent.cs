using Microsoft.AspNetCore.Components;

namespace ComponentFundamentals.Components.Pages;

/// <summary>
/// The advanced component - Implements <see cref="IComponent"/> interface directly => no Blazor lifecycle methods.
/// </summary>
public class AdvancedComponent : LayoutComponentBase, IComponent
{
    private readonly RenderFragment _renderFragment;
    private RenderHandle _renderHandle;

    /// <summary>
    /// Constructs an instance of <see cref="ComponentBase"/>.
    /// </summary>
    public AdvancedComponent()
    {
        _renderFragment = builder =>
        {
            builder.OpenElement(0, "p");
            builder.AddContent(1, "Im here!");
            builder.CloseElement();
        };
    }

    void IComponent.Attach(RenderHandle renderHandle)
    {
        if (_renderHandle.IsInitialized)
        {
            throw new InvalidOperationException($"The render handle is already set. Cannot initialize a {nameof(ComponentBase)} more than once.");
        }

        _renderHandle = renderHandle;
    }

    public override Task SetParametersAsync(ParameterView parameters)
    {
        parameters.SetParameterProperties(this);

        _renderHandle.Render(_renderFragment);

        return Task.CompletedTask;
    }
}
