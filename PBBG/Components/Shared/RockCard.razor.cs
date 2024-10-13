using Microsoft.AspNetCore.Components;
using PBBG.Contracts;

namespace PBBG.Components.Shared;

public partial class RockCard
{
    [Parameter]
    public Rock Rock { get; set; }
    
    [Parameter]
    public Func<Rock, Task>? HarvestRockCommand { get; set; }

    private async Task HarvestRock()
    {
        await HarvestRockCommand?.Invoke(Rock);
    }
}