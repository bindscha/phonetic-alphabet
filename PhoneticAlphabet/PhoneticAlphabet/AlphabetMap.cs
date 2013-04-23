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
    public class AlphabetMap : ObservableCollection<LetterMap>
    {
        public AlphabetMap() { }

        public void LoadNATOData()
        {
            this.Clear();
            this.Add(new LetterMap("A", "ALPHA"));
            this.Add(new LetterMap("B", "BRAVO"));
            this.Add(new LetterMap("C", "CHARLIE"));
            this.Add(new LetterMap("D", "DELTA"));
            this.Add(new LetterMap("E", "ECHO"));
            this.Add(new LetterMap("F", "FOXTROT"));
            this.Add(new LetterMap("G", "GOLF"));
            this.Add(new LetterMap("H", "HOTEL"));
            this.Add(new LetterMap("I", "INDIA"));
            this.Add(new LetterMap("J", "JULIET"));
            this.Add(new LetterMap("K", "KILO"));
            this.Add(new LetterMap("L", "LIMA"));
            this.Add(new LetterMap("M", "MIKE"));
            this.Add(new LetterMap("N", "NOVEMBER"));
            this.Add(new LetterMap("O", "OSCAR"));
            this.Add(new LetterMap("P", "PAPA"));
            this.Add(new LetterMap("Q", "QUEBEC"));
            this.Add(new LetterMap("R", "ROMEO"));
            this.Add(new LetterMap("S", "SIERRA"));
            this.Add(new LetterMap("T", "TANGO"));
            this.Add(new LetterMap("U", "UNIFORM"));
            this.Add(new LetterMap("V", "VICTOR"));
            this.Add(new LetterMap("W", "WHISKEY"));
            this.Add(new LetterMap("X", "X-RAY"));
            this.Add(new LetterMap("Y", "YANKEE"));
            this.Add(new LetterMap("Z", "ZULU"));
            this.Add(new LetterMap("0", "ZERO"));
            this.Add(new LetterMap("1", "ONE"));
            this.Add(new LetterMap("2", "TWO"));
            this.Add(new LetterMap("3", "THREE"));
            this.Add(new LetterMap("4", "FOUR"));
            this.Add(new LetterMap("5", "FIVE"));
            this.Add(new LetterMap("6", "SIX"));
            this.Add(new LetterMap("7", "SEVEN"));
            this.Add(new LetterMap("8", "EIGHT"));
            this.Add(new LetterMap("9", "NINE"));
            this.Add(new LetterMap(".", "DECIMAL"));
        }

        public void LoadUSArmyNavyData()
        {
            this.Clear();
            this.Add(new LetterMap("A", "ABLE"));
            this.Add(new LetterMap("B", "BAKER"));
            this.Add(new LetterMap("C", "CHARLIE"));
            this.Add(new LetterMap("D", "DOG"));
            this.Add(new LetterMap("E", "EASY"));
            this.Add(new LetterMap("F", "FOX"));
            this.Add(new LetterMap("G", "GEORGE"));
            this.Add(new LetterMap("H", "HOW"));
            this.Add(new LetterMap("I", "ITEM"));
            this.Add(new LetterMap("J", "JIG"));
            this.Add(new LetterMap("K", "KING"));
            this.Add(new LetterMap("L", "LOVE"));
            this.Add(new LetterMap("M", "MIKE"));
            this.Add(new LetterMap("N", "NAN"));
            this.Add(new LetterMap("O", "OBOE"));
            this.Add(new LetterMap("P", "PETER"));
            this.Add(new LetterMap("Q", "QUEEN"));
            this.Add(new LetterMap("R", "ROGER"));
            this.Add(new LetterMap("S", "SAIL"));
            this.Add(new LetterMap("T", "TARE"));
            this.Add(new LetterMap("U", "UNCLE"));
            this.Add(new LetterMap("V", "VICTOR"));
            this.Add(new LetterMap("W", "WILLIAM"));
            this.Add(new LetterMap("X", "X-RAY"));
            this.Add(new LetterMap("Y", "YOKE"));
            this.Add(new LetterMap("Z", "ZEBRA"));
            this.Add(new LetterMap("0", "ZERO"));
            this.Add(new LetterMap("1", "ONE"));
            this.Add(new LetterMap("2", "TWO"));
            this.Add(new LetterMap("3", "THREE"));
            this.Add(new LetterMap("4", "FOUR"));
            this.Add(new LetterMap("5", "FIVE"));
            this.Add(new LetterMap("6", "SIX"));
            this.Add(new LetterMap("7", "SEVEN"));
            this.Add(new LetterMap("8", "EIGHT"));
            this.Add(new LetterMap("9", "NINE"));
            this.Add(new LetterMap(".", "DECIMAL"));
        }

        public void LoadLAPDData()
        {
            this.Clear();
            this.Add(new LetterMap("A", "ADAM"));
            this.Add(new LetterMap("B", "BOY"));
            this.Add(new LetterMap("C", "CHARLES"));
            this.Add(new LetterMap("D", "DAVID"));
            this.Add(new LetterMap("E", "EDWARD"));
            this.Add(new LetterMap("F", "FRANK"));
            this.Add(new LetterMap("G", "GEORGE"));
            this.Add(new LetterMap("H", "HENRY"));
            this.Add(new LetterMap("I", "IDA"));
            this.Add(new LetterMap("J", "JOHN"));
            this.Add(new LetterMap("K", "KING"));
            this.Add(new LetterMap("L", "LINCOLN"));
            this.Add(new LetterMap("M", "MARY"));
            this.Add(new LetterMap("N", "NORA"));
            this.Add(new LetterMap("O", "OCEAN"));
            this.Add(new LetterMap("P", "PAUL"));
            this.Add(new LetterMap("Q", "QUEEN"));
            this.Add(new LetterMap("R", "ROBERT"));
            this.Add(new LetterMap("S", "SAM"));
            this.Add(new LetterMap("T", "TOM"));
            this.Add(new LetterMap("U", "UNION"));
            this.Add(new LetterMap("V", "VICTOR"));
            this.Add(new LetterMap("W", "WILLIAM"));
            this.Add(new LetterMap("X", "X-RAY"));
            this.Add(new LetterMap("Y", "YOUNG"));
            this.Add(new LetterMap("Z", "ZEBRA"));
            this.Add(new LetterMap("0", "ZERO"));
            this.Add(new LetterMap("1", "ONE"));
            this.Add(new LetterMap("2", "TWO"));
            this.Add(new LetterMap("3", "THREE"));
            this.Add(new LetterMap("4", "FOUR"));
            this.Add(new LetterMap("5", "FIVE"));
            this.Add(new LetterMap("6", "SIX"));
            this.Add(new LetterMap("7", "SEVEN"));
            this.Add(new LetterMap("8", "EIGHT"));
            this.Add(new LetterMap("9", "NINE"));
            this.Add(new LetterMap(".", "DECIMAL"));
        }

        public void LoadWesternUnionData()
        {
            this.Clear();
            this.Add(new LetterMap("A", "ADAMS"));
            this.Add(new LetterMap("B", "BOSTON"));
            this.Add(new LetterMap("C", "CHICAGO"));
            this.Add(new LetterMap("D", "DENVER"));
            this.Add(new LetterMap("E", "EASY"));
            this.Add(new LetterMap("F", "FRANK"));
            this.Add(new LetterMap("G", "GEORGE"));
            this.Add(new LetterMap("H", "HENRY"));
            this.Add(new LetterMap("I", "IDA"));
            this.Add(new LetterMap("J", "JOHN"));
            this.Add(new LetterMap("K", "KING"));
            this.Add(new LetterMap("L", "LINCOLN"));
            this.Add(new LetterMap("M", "MARY"));
            this.Add(new LetterMap("N", "NEW-YORK"));
            this.Add(new LetterMap("O", "OCEAN"));
            this.Add(new LetterMap("P", "PETER"));
            this.Add(new LetterMap("Q", "QUEEN"));
            this.Add(new LetterMap("R", "ROGER"));
            this.Add(new LetterMap("S", "SUGAR"));
            this.Add(new LetterMap("T", "THOMAS"));
            this.Add(new LetterMap("U", "UNION"));
            this.Add(new LetterMap("V", "VICTOR"));
            this.Add(new LetterMap("W", "WILLIAM"));
            this.Add(new LetterMap("X", "X-RAY"));
            this.Add(new LetterMap("Y", "YOUNG"));
            this.Add(new LetterMap("Z", "ZERO"));
            this.Add(new LetterMap("0", "ZERO"));
            this.Add(new LetterMap("1", "ONE"));
            this.Add(new LetterMap("2", "TWO"));
            this.Add(new LetterMap("3", "THREE"));
            this.Add(new LetterMap("4", "FOUR"));
            this.Add(new LetterMap("5", "FIVE"));
            this.Add(new LetterMap("6", "SIX"));
            this.Add(new LetterMap("7", "SEVEN"));
            this.Add(new LetterMap("8", "EIGHT"));
            this.Add(new LetterMap("9", "NINE"));
            this.Add(new LetterMap(".", "DECIMAL"));
        }

        public void LoadFrenchData()
        {
            this.Clear();
            this.Add(new LetterMap("A", "ANATOLE"));
            this.Add(new LetterMap("B", "BERTHE"));
            this.Add(new LetterMap("C", "CÉLESTIN"));
            this.Add(new LetterMap("D", "DÉSIRÉ"));
            this.Add(new LetterMap("E", "EUGÈNE"));
            this.Add(new LetterMap("F", "FRANÇOIS"));
            this.Add(new LetterMap("G", "GASTON"));
            this.Add(new LetterMap("H", "HENRI"));
            this.Add(new LetterMap("I", "IRMA"));
            this.Add(new LetterMap("J", "JOSEPH"));
            this.Add(new LetterMap("K", "KLÉBER"));
            this.Add(new LetterMap("L", "LOUIS"));
            this.Add(new LetterMap("M", "MARCEL"));
            this.Add(new LetterMap("N", "NICOLAS"));
            this.Add(new LetterMap("O", "OSCAR"));
            this.Add(new LetterMap("P", "PIERRE"));
            this.Add(new LetterMap("Q", "QUINTAL"));
            this.Add(new LetterMap("R", "RAOUL"));
            this.Add(new LetterMap("S", "SUZANNE"));
            this.Add(new LetterMap("T", "THÉRÈSE"));
            this.Add(new LetterMap("U", "URSULE"));
            this.Add(new LetterMap("V", "VICTOR"));
            this.Add(new LetterMap("W", "WILLIAM"));
            this.Add(new LetterMap("X", "XAVIER"));
            this.Add(new LetterMap("Y", "YVONNE"));
            this.Add(new LetterMap("Z", "ZOÉ"));
            this.Add(new LetterMap("0", "ZÉRO"));
            this.Add(new LetterMap("1", "UN"));
            this.Add(new LetterMap("2", "DEUX"));
            this.Add(new LetterMap("3", "TROIS"));
            this.Add(new LetterMap("4", "QUATRE"));
            this.Add(new LetterMap("5", "CINQ"));
            this.Add(new LetterMap("6", "SIX"));
            this.Add(new LetterMap("7", "SEPT"));
            this.Add(new LetterMap("8", "HUIT"));
            this.Add(new LetterMap("9", "NEUF"));
            this.Add(new LetterMap(".", "DÉCIMALE"));
        }
    }
}
