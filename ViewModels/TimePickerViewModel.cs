using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimePicker.ViewModels
{
    public class TimePickerViewModel : INotifyPropertyChanged
    {
        private TimeSpan _selectedTime;

        public TimeSpan SelectedTime
        {
            get => _selectedTime;
            set
            {
                if (_selectedTime != value)
                {
                    _selectedTime = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
