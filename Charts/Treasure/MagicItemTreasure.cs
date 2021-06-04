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
        double Percent { get; set; }


        ///// <summary>
        ///// This is the Name of the type of MagicItemTreasure.
        ///// </summary>
        //public string Name { get; set; }



        ///<summary>
        ///This is the type of magic item
        /// </summary>
        public string MagicItemType { get; set; }

        public MagicItemTreasure(string magicItemType, double percent )
        {
            MagicItemType = magicItemType;
            Percent = percent;
        }

        public Utilities.Dice GetMagicItemSubtable(double percent)
        {
            double percent;
            if (percent =< 20)//if percent is less than or equal to 20 then swords.
            {
                Swords;
            }
            else if (percent > 20 && percent <= 30)
            {
                Other Weapons;
            }
            else if (percent > 30 && percent <= 40)
            {
                Armor and Shields;
            }
            else if (percent > 40 && percent <= 65)
            {
                Potions;
            }
            else if (percent > 65 && percent <= 85)
            {
                Scrolls;
            }
            else if (percent > 85 && percent <= 90)
            {
                Rings;
            }
            else if (percent > 90 && percent <= 95)
            {
                Wands, Staves, and Wands;
            }
            else
            {
                Miscellaneous Magic;
            }
            return char;
        }
    }
}
