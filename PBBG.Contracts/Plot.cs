using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace PBBG.Contracts;

public class Plot: INotifyPropertyChanged
{
    public Vector2 Position { get; set; }
    public int PlotType { get; set; } = 0;
    public int Quantity { get; set; } = 0;
    
    
    private bool isWatered = false;
    public bool IsWatered
    {
        get
        {
            return this.isWatered;
        }
        set
        {
            if (isWatered == value) return;
            
            isWatered = value;
            OnPropertyChanged(nameof(IsWatered));
        }
    }
    
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}