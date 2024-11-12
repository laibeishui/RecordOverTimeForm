using System;
using System.ComponentModel;

namespace RecordOverTimeForm.Model
{
    public class TimePickerModel : INotifyPropertyChanged
    {
        private DateTime startTime;
        private TimeSpan minTime;
        private TimeSpan maxTime;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime StartTime
        {
            get => startTime;
            set
            {
                if (value.TimeOfDay >= MinTime && value.TimeOfDay <= MaxTime)
                {
                    startTime = value;
                    OnPropertyChanged(nameof(StartTime));
                }
            }
        }

        public TimeSpan MinTime
        {
            get => minTime;
            set
            {
                minTime = value;
                OnPropertyChanged(nameof(MinTime));
            }
        }

        public TimeSpan MaxTime
        {
            get => maxTime;
            set
            {
                maxTime = value;
                OnPropertyChanged(nameof(MaxTime));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
