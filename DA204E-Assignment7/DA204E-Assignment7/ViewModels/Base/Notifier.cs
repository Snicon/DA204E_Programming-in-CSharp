﻿// Sixten Peterson (AQ9300) 2025-05-26
using System.ComponentModel;

namespace DA204E_Assignment7
{
    /// <summary>
    /// This class is completley based on the example provided in "Learn WPF MVVM XAML" by Arnaud Weil, see page 90 - 92 if interested. Basically this class is used to notify the ui when a property is updated by firing an event.
    /// </summary>
    public class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
