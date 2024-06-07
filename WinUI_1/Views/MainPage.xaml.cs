﻿using Microsoft.UI.Xaml.Controls;

using WinUI_1.ViewModels;

namespace WinUI_1.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
