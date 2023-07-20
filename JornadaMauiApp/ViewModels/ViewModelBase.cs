﻿namespace JornadaMauiApp.ViewModels;

public abstract class ViewModelBase : ObservableObject
{
    private string title;

    public string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    private bool isBusy;

    public bool IsBusy
    {
        get => isBusy;
        set => SetProperty(ref isBusy, value);
    }
}
