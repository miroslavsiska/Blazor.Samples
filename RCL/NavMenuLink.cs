using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Routing;

namespace RCL;

/// <summary>
/// The nav menu link component.
/// </summary>
public class NavMenuLink : ComponentBase
{
    /// <summary>
    /// The nav item link.
    /// </summary>
    [Parameter] public string Href { get; set; } = string.Empty;

    /// <summary>
    /// The nav item text.
    /// </summary>
    [Parameter] public string? Text { get; set; }

    /// <summary>
    /// The nav item icon CSS class.
    /// </summary>
    [Parameter] public string? IconCssClass { get; set; }

    /// <summary>
    /// Modifies the URL matching behavior for a <see cref="NavLink"/>.
    /// </summary>
    [Parameter] public NavLinkMatch? Match { get; set; }


    /// <inheritdoc/>
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "div");
        builder.AddAttribute(1, "class", "nav-item px-3");

        builder.OpenComponent<NavLink>(100);
        builder.AddAttribute(101, "class", "nav-link");
        builder.AddAttribute(102, "href", this.Href);

        if (Match is not null)
        {
            builder.AddAttribute(103, nameof(NavLink.Match), this.Match);
        }

        builder.AddAttribute(104, nameof(NavLink.ChildContent), (RenderFragment?)(b =>
        {
            if (!string.IsNullOrEmpty(IconCssClass))
            {
                b.OpenElement(200, "span");
                b.AddAttribute(201, "class", this.IconCssClass);
                b.AddAttribute(202, "aria-hidden", "true");
                b.CloseElement();
            }

            if (!string.IsNullOrEmpty(this.Text))
            {
                b.AddContent(300, this.Text);
            }
        }));
        builder.CloseComponent();

        builder.CloseElement();
    }
}
