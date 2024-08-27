namespace TimePicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTimePickerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(timePicker.Time))
            {
                var selectedTime = timePicker.Time;
            }
        }
    }

}
