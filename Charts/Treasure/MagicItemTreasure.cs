using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class MagicItemTreasure
    {
        #region Properties

        /// <summary>
        /// This is a percentange from 01-100.
        /// </summary>
        public double Percent { get; set; }

        public Utilities.Dice Dice { get; set; }

        /// <summary>
        /// This is the magic item type name 
        /// </summary>
        /// <example>sword, potion, rings</example>
        public string NameType { get; set; }

        
        ///<summary>
        ///This is the type of magic item
        /// </summary>
        public string MagicItemType { get; set; }

        #endregion Properties

        public MagicItemTreasure(string magicItemType, double percent, string nameType )
        {
            MagicItemType = magicItemType;
            Percent = percent;
            NameType = nameType;
            Dice = Utilities.Dice.D100;
        }

        //public Utilities.Dice GetMagicItemSubtable(double percent)
        //{
        //    double percent;
        //    if (percent =< 20)//if percent is less than or equal to 20 then swords.
        //    {
        //        Swords;
        //    }
        //    else if (percent > 20 && percent <= 30)
        //    {
        //        Other Weapons;
        //    }
        //    else if (percent > 30 && percent <= 40)
        //    {
        //        Armor and Shields;
        //    }
        //    else if (percent > 40 && percent <= 65)
        //    {
        //        Potions;
        //    }
        //    else if (percent > 65 && percent <= 85)
        //    {
        //        Scrolls;
        //    }
        //    else if (percent > 85 && percent <= 90)
        //    {
        //        Rings;
        //    }
        //    else if (percent > 90 && percent <= 95)
        //    {
        //        Wands, Staves, and Wands;
        //    }
        //    else
        //    {
        //        Miscellaneous Magic;
        //    }
        //    return char;
        //}
    }
}
