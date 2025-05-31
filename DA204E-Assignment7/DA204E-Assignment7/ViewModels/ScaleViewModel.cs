// Sixten Peterson (AQ9300) 2025-05-26
using DA204E_Assignment7.Models;

namespace DA204E_Assignment7.ViewModels
{
    /// <summary>
    /// ViewModel for the Scale View, implements Notifier for easier notification of required ui updates.
    /// The logic in this class includes adding all scales that will be used in conversion,
    /// as well as ui clearing and calculations.
    /// </summary>
    class ScaleViewModel : Notifier
    {
        private string value; // The value that is being inputted by the user in the form
        private List<Scale> scales; // List of all scales that can be converted to or form
        private Scale selectedScale; // The currently selected scale (will be used to convert from

        /// <summary>
        /// Simple constructor. Creates a new List containg all scales that will be used for conversion and defaults the combobox ui to the first available element
        /// </summary>
        public ScaleViewModel()
        {
            Scales = new List<Scale> // Creating a new list of scales
            {
                // Creating all the scales belows
                new Scale("H0", 87.0m),
                new Scale("N", 160.0m),
                new Scale("Z", 220.0m),
                new Scale("0", 45.0m),
                new Scale("1", 32.0m),
                new Scale("G", 22.5m),
                new Scale("00", 76.2m)
            };

            selectedScale = Scales.First(); // Defaulting to the first available scale in the combobox
        }

        /// <summary>
        /// Property for the value field
        /// </summary>
        public string Value
        {
            get { return value; }
            set
            {
                this.value = value; // Setting the value, no specific rules
                OnPropertyChanged("Value"); // Notifying the UI that the property changed
                OnValueChanged(); // Just calling this method to do something everytime the value changes, theres probably a better way of doing this but this approach is the simplest.
            }
        }

        /// <summary>
        /// Property for the scales field
        /// </summary>
        public List<Scale> Scales
        {
            get { return scales; }
            set
            {
                scales = value; // Setting the scales
                OnPropertyChanged("Scales"); // Notifying the UI of the change
            }
        }

        /// <summary>
        /// Property for selectedScale field
        /// </summary>
        public Scale SelectedScale
        {
            get { return selectedScale; }
            set
            {
                selectedScale = value; // Setting the selectedScale
                OnPropertyChanged("SelectedScale"); // Notifying the UI of the change
                OnSelectedScaleChanged(); // Just calling this method to do something everytime the slectedScale changes
            }
        }

        // Individual properties for each converted value, these are binded to in the view. I tried using a list for converted values first but it didn't work very well, hence why I opted for this "sloppy" approach. Not very DRY.
        public string H0Value { get; set; }
        public string NValue { get; set; }
        public string ZValue { get; set; }
        public string ZeroValue { get; set; }
        public string OneValue { get; set; }
        public string GValue { get; set; }
        public string ZeroZeroValue { get; set; }

        /// <summary>
        /// Calls ComputeConverted, allows for additional features in the future by having it implemented like this instead of just calling ComputeConverted directly.
        /// </summary>
        private void OnSelectedScaleChanged()
        {
            ComputeConverted();
        }

        /// <summary>
        /// Resets the converted values if the value field is empty and computes a new conversion if value isn't empty.
        /// </summary>
        private void OnValueChanged()
        {
            if (string.IsNullOrWhiteSpace(Value))
            {
                ResetConvertedValues(); // Reset converted values if input is empty
            }
            else
            {
                ComputeConverted(); // Converts the value
            }
        }

        /// <summary>
        /// Resets the UI by changing all the converted values properties to 0 and notifying the change.
        /// </summary>
        private void ResetConvertedValues()
        {
            //Setting all the convert values to 0
            H0Value = "0";
            NValue = "0";
            ZValue = "0";
            ZeroValue = "0";
            OneValue = "0";
            GValue = "0";
            ZeroZeroValue = "0";

            NotifyConvertValues(); // Notifying UI of property changes
        }

        /// <summary>
        /// Converts the value from the form into all of the different scales.
        /// </summary>
        private void ComputeConverted()
        {
            if (SelectedScale == null || string.IsNullOrWhiteSpace(Value)) // Cant convert from a scale that isn't selected and can't convert an empty stirng
            {
                return; // No point in running any further
            }

            if (!decimal.TryParse(Value, out decimal inputValue))
            {
                ResetConvertedValues(); // Reset values if input is invalid
                return; // We wouldn't want any other code to run
            }

            decimal selectedScaleRatio = SelectedScale.Ratio; // Get the ratio of the selected scale

            // Calculate the base value in terms of H0
            decimal h0Ratio = Scales.First(s => s.Name == "H0").Ratio; // Getting the H0 scale form the list of scales
            decimal baseValue = inputValue * (selectedScaleRatio / h0Ratio);

            // Convert to all scales and stroing thems as strings with three decimals
            H0Value = (baseValue * (h0Ratio / Scales.First(s => s.Name == "H0").Ratio)).ToString("F3");
            NValue = (baseValue * (h0Ratio / Scales.First(s => s.Name == "N").Ratio)).ToString("F3");
            ZValue = (baseValue * (h0Ratio / Scales.First(s => s.Name == "Z").Ratio)).ToString("F3");
            ZeroValue = (baseValue * (h0Ratio / Scales.First(s => s.Name == "0").Ratio)).ToString("F3"); ;
            OneValue = (baseValue * (h0Ratio / Scales.First(s => s.Name == "1").Ratio)).ToString("F3"); ;
            GValue = (baseValue * (h0Ratio / Scales.First(s => s.Name == "G").Ratio)).ToString("F3"); ;
            ZeroZeroValue = (baseValue * (h0Ratio / Scales.First(s => s.Name == "00").Ratio)).ToString("F3"); ;

            NotifyConvertValues();
        }

        /// <summary>
        /// Small helper method for notifying the UI of property changes for all scale properties to keep things DRY
        /// </summary>
        private void NotifyConvertValues()
        {
            OnPropertyChanged("H0Value");
            OnPropertyChanged("NValue");
            OnPropertyChanged("ZValue");
            OnPropertyChanged("ZeroValue");
            OnPropertyChanged("OneValue");
            OnPropertyChanged("GValue");
            OnPropertyChanged("ZeroZeroValue");
        }
    }
}
