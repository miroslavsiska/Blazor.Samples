using ComponentFundamentals.Components.Services;
using Microsoft.AspNetCore.Components;

namespace ComponentFundamentals.Components.Pages;

/// <summary>
/// Sample code how to inject service to the component using build-in dependency injection.
/// </summary>
public partial class DependencyInjection
{
    // First option in code file
    [Inject] private StateService _stateService { get; set; } = default!;


    //// Second option in code file
    //private readonly StateService _state;
    //public DependencyInjection(StateService stateService )
    //{
    //    _stateService = stateService ;
    //}

}
