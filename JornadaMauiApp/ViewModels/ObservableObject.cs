using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JornadaMauiApp.ViewModels;

public abstract class ObservableObject : INotifyPropertyChanged
{
    protected bool SetProperty<T>(ref T field, T newValue,
        Action onChanged = null,
        [CallerMemberName] string propertyName = "")
    {
        field = newValue;
        OnPropertyChanged(propertyName);
        onChanged?.Invoke();
        return true;
    }

    private void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new(propertyName));

    public event PropertyChangedEventHandler PropertyChanged;
}
