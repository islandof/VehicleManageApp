﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace VehicleManageApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public ViewModelNavigation Navigation { get; set; }
        protected BaseViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
