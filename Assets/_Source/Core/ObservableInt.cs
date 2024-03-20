using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Core 
{
    public class ObservableInt :  INotifyPropertyChanged
    {
        public ObservableInt(int value)
            {
                this.value = value;
            }

            private int value;

            public int Value
            {
                get 
                {
                    return value;
                }
                set 
                { 
                    this.value = value; NotifyPropertyChanged(nameof(Value)); 
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;

            internal void NotifyPropertyChanged(string propertyName) 
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
    }

}
