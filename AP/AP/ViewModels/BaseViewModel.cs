﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace AP.ViewModels
{ 
   public class BaseViewModel : INotifyPropertyChanged
  {

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
    protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)

    {
        if (EqualityComparer<T>.Default.Equals(backingField, value))
        {
            return;
        }
        backingField = value;
        this.OnPropertyChanged(propertyName);
    }

 }
}

