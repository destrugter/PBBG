using Microsoft.AspNetCore.Components;
using PBBG.Contracts;

namespace PBBG.Components.Shared;

public partial class MineCard
{
    [Parameter]
    public Mine Mine { get; set; }
}