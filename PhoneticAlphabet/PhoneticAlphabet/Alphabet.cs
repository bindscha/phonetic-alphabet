using System.ComponentModel;

namespace PhoneticAlphabet
{
    public class Alphabet : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private AlphabetMap map;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != description)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        public AlphabetMap Map
        {
            get
            {
                return map;
            }
            set
            {
                if (value != map)
                {
                    map = value;
                    NotifyPropertyChanged("Map");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor with full city information
        /// </summary>
        public Alphabet(string _name, string _description, AlphabetMap _map)
        {
            name = _name;
            description = _description;
            map = _map;
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
