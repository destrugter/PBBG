using System.ComponentModel;
using System.Timers;
using Microsoft.AspNetCore.Components;
using PBBG.Contracts;

namespace PBBG.Components.Shared;

public partial class PlotComponent: ComponentBase, IDisposable
{
    [Parameter]
    public Plot Plot { get; set; }

    [Parameter]
    public Func<Plot, Task>? ProcessPlotCommand { get; set; }
    
    private System.Timers.Timer? timer;

    protected override void OnInitialized()
    {
        // Subscribe to the PropertyChanged event to monitor changes
        Plot.PropertyChanged += PlotInstance_PropertyChanged;
        
        timer = new System.Timers.Timer(1000); // 1000 ms = 1 second
        timer.Elapsed += OnTimerElapsed;
        timer.AutoReset = true; // Ensure the timer keeps firing
        timer.Start();
    }

    private void OnTimerElapsed(object? sender, ElapsedEventArgs e)
    {
        InvokeAsync(() =>
        {
            Plot.Quantity++;
            StateHasChanged(); // Update the UI
        });
    }

    private void PlotInstance_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        // React to the boolean property change
        if (e.PropertyName == nameof(Plot.IsWatered))
        {
            // Trigger a UI refresh when the boolean changes
            StateHasChanged();
        }
    }

    public void Dispose()
    {
        // Unsubscribe to prevent memory leaks
        Plot.PropertyChanged -= PlotInstance_PropertyChanged;
    }
    
    private async Task PlotClicked()
    {
        await ProcessPlotCommand?.Invoke(Plot);
    }
}