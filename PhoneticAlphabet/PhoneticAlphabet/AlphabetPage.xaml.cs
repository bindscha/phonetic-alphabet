/* 
    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
  
*/
using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;


namespace PhoneticAlphabet
{
    public partial class AlphabetPage : PhoneApplicationPage
    {
        public AlphabetPage()
        {
            InitializeComponent();

            foreach (Alphabet alphabet in App.alphabetList)
            {
                PivotItem p = new PivotItem();
                p.Header = alphabet.Name;

                AlphabetControl control = new AlphabetControl();
                control.DataContext = alphabet;

                control.AlphabetMap.Items.Clear();
                foreach(LetterMap letter in alphabet.Map)
                {
                    TextBlock text = new TextBlock();
                    text.Text = letter.Letter + "\t->\t" + letter.Phonetic;
                    control.AlphabetMap.Items.Add(text);
                }

                p.Content = control;

                AlphabetPivot.Items.Add(p);
            }

            /*for(int i = 0; i < App.areaList.Count; ++i)
            {
                Area area = App.areaList[i];

                ForecastControl control = new ForecastControl();
                control.DataContext = area;

                control.SetForecastText(area.Forecast);

                ((PivotItem)AreasPivot.Items[i]).Content = control;
            }*/
        }

        /// <summary>
        /// Event handler to handle when this page is navigated to
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

    }
}
