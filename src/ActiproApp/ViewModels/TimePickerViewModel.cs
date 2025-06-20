using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ActiproApp.ViewModels
{

    public partial class TimePickerViewModel : ObservableObject
    {
        [ObservableProperty] private DateTime? selectedTime;
    }
}