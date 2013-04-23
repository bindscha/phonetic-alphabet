using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace PhoneticAlphabet
{
    public class MenuItems : ObservableCollection<MenuItem>
    {
        public MenuItems() { }

        /// <summary>
        /// Create a default list of areas
        /// </summary>
        public void LoadDefaultData()
        {
            App.MenuItemsList.Add(new MenuItem("Spell It For Me!", "Automatically spell some text in the phonetic alphabet of your choosing.", "/PhoneticAlphabet;component/spell.png"));
            App.MenuItemsList.Add(new MenuItem("Browse Alphabets", "Browse a complete reference of phonetic alphabets.", "/PhoneticAlphabet;component/reference.png"));
            App.MenuItemsList.Add(new MenuItem("About", "About this application.", "/PhoneticAlphabet;component/about.png"));
        }

    }
}
