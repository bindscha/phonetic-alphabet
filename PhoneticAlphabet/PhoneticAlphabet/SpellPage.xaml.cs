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
    public partial class SpellPage : PhoneApplicationPage
    {
        private bool ignore = false;

        public SpellPage()
        {
            InitializeComponent();
            Loaded += Page_Loaded;
        }

        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            clearChecked();
            NATO.IsChecked = true;
        }

        private void translate()
        {
            string inputText = Input.Text;
            string capitalizedInput = inputText.ToUpperInvariant();
            string spacedInput = insertSpaces(capitalizedInput);
            string replacedInput = replaceLetters(spacedInput, selectedAlphabet());
            string outputText = replacedInput;
            Translation.Text = outputText;
        }

        private string insertSpaces(string input)
        {
            string output = "";
            foreach (char c in input)
            {
                if (!Char.IsWhiteSpace(c))
                {
                    output += c + " ";
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }

        private string replaceLetters(string input, Alphabet alphabet)
        {
            string output = "";
            foreach (char c in input)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    int index = ((int)c) - ((int)'A');
                    output += alphabet.Map[index].Phonetic;
                }
                else if (c >= '0' && c <= '9')
                {
                    int index = 26 + ((int)c) - ((int)'0');
                    output += alphabet.Map[index].Phonetic;
                }
                else if (c == '.')
                {
                    int index = 26 + 10;
                    output += alphabet.Map[index].Phonetic;
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }

        private Alphabet selectedAlphabet()
        {
            if (NATO.IsChecked.Value)
            {
                return App.alphabetList[0];
            }
            else if (US.IsChecked.Value)
            {
                return App.alphabetList[1];
            }
            else if (LAPD.IsChecked.Value)
            {
                return App.alphabetList[2];
            }
            else if (WU.IsChecked.Value)
            {
                return App.alphabetList[3];
            }
            else if (French.IsChecked.Value)
            {
                return App.alphabetList[4];
            }
            else
            {
                return null;
            }
        }

        private void clearChecked()
        {
            NATO.IsChecked = false;
            US.IsChecked = false;
            French.IsChecked = false;
            WU.IsChecked = false;
            LAPD.IsChecked = false;
        }

        private void NATO_Checked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                ignore = true;
                clearChecked();
                NATO.IsChecked = true;
                translate();
                ignore = false;
            }
        }

        private void NATO_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                NATO.IsChecked = true;
            }
        }

        private void LAPD_Checked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                ignore = true;
                clearChecked();
                LAPD.IsChecked = true;
                translate();
                ignore = false;
            }
        }

        private void LAPD_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                LAPD.IsChecked = true;
            }
        }

        private void US_Checked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                ignore = true;
                clearChecked();
                US.IsChecked = true;
                translate();
                ignore = false;
            }
        }

        private void US_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                US.IsChecked = true;
            }
        }

        private void French_Checked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                ignore = true;
                clearChecked();
                French.IsChecked = true;
                translate();
                ignore = false;
            }
        }

        private void French_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                French.IsChecked = true;
            }
        }

        private void WU_Checked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                ignore = true;
                clearChecked();
                WU.IsChecked = true;
                translate();
                ignore = false;
            }
        }

        private void WU_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!ignore)
            {
                WU.IsChecked = true;
            }
        }

        private void RecomputeTranslation(object sender, TextChangedEventArgs e)
        {
            translate();
        }
    }
}