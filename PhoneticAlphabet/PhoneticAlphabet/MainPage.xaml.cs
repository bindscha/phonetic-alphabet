using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneticAlphabet
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            App.MenuItemsList.LoadDefaultData();
            MenuList.ItemsSource = App.MenuItemsList;

            App.alphabetList.LoadDefaultData();
        }

        /// <summary>
        /// Event handler called when user selects a city to get a forecast for
        /// </summary>
        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // if an item is selected
            if (MenuList.SelectedIndex == 0)
            {
                this.NavigationService.Navigate(new Uri("/SpellPage.xaml", UriKind.Relative));
            }
            else if (MenuList.SelectedIndex == 1)
            {
                this.NavigationService.Navigate(new Uri("/AlphabetPage.xaml", UriKind.Relative));
            }
            else if (MenuList.SelectedIndex == 2)
            {
                this.NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
            }

            MenuList.SelectedIndex = -1;
        }

    }
}