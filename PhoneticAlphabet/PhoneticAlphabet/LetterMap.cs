using System.ComponentModel;

namespace PhoneticAlphabet
{
    public class LetterMap : INotifyPropertyChanged
    {
        private string letter;
        private string phonetic;

        public string Letter
        {
            get
            {
                return letter;
            }
            set
            {
                if (value != letter)
                {
                    letter = value;
                    NotifyPropertyChanged("Letter");
                }
            }
        }

        public string Phonetic
        {
            get
            {
                return phonetic;
            }
            set
            {
                if (value != phonetic)
                {
                    phonetic = value;
                    NotifyPropertyChanged("Phonetic");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor with full city information
        /// </summary>
        public LetterMap(string _letter, string _phonetic)
        {
            letter = _letter;
            phonetic = _phonetic;
        }

        /// <summary>
        /// Raise the PropertyChanged event and pass along the property that changed
        /// </summary>
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
