/* 
    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
  
*/
using System.Collections.ObjectModel;

namespace PhoneticAlphabet
{
    public class Alphabets  : ObservableCollection<Alphabet>
    {
        public Alphabets() { }

        /// <summary>
        /// Create a default list of areas
        /// </summary>
        public void LoadDefaultData()
        {
            AlphabetMap natoMap = new AlphabetMap();
            natoMap.LoadNATOData();
            AlphabetMap usArmyNavyMap = new AlphabetMap();
            usArmyNavyMap.LoadUSArmyNavyData();
            AlphabetMap lapdMap = new AlphabetMap();
            lapdMap.LoadLAPDData();
            AlphabetMap westernUnionMap = new AlphabetMap();
            westernUnionMap.LoadWesternUnionData();
            AlphabetMap frenchMap = new AlphabetMap();
            frenchMap.LoadFrenchData();

            App.alphabetList.Add(new Alphabet("NATO", "Developed in the 1950s to be intelligible to all NATO allies in the heat of battle", natoMap));
            App.alphabetList.Add(new Alphabet("US Army/Navy", "Developed in 1941 and used by all branches of the United States military until 1956", usArmyNavyMap));
            App.alphabetList.Add(new Alphabet("LAPD", "Used by the Los Angeles Police Department (LAPD) and other local and state law enforcement agencies in the state of California", lapdMap)); 
            App.alphabetList.Add(new Alphabet("Western Union", "Used by Western Union as a commercial alphabet", westernUnionMap)); 
            App.alphabetList.Add(new Alphabet("French", "Assigns French names to letters and numbers", frenchMap));
        }

    }

}
