using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class GemTreasure
    {
        /// <summary>
        /// Name of the treasure.
        /// </summary>
        public string TreasureName { get; set; }

        /// <summary>
        /// Type of dice.
        /// </summary>
        public Dice Dice { get; set; }//This is here because it is in the JewelryTreasure.cs. Not sure why or if I even need this.

        /// <summary>
        /// not sure what to put because the Name of this ?Constructor? is not descriptive enough. Please help!
        /// </summary>
        public int MinimumValue { get; set; }//If these are minimum number of gems then this should be changed to be more descriptive?
        /// <summary>
        /// See above ^^^.
        /// </summary>
        public int MaximumValue { get; set; }//See above ^.
        /// <summary>
        /// Percent.
        /// </summary>
        public double Percent { get; set; }



        /// <summary>
        /// Type of Gem.
        /// </summary>
        public GemType GemType { get; set; }//Is this needed? Is it wrong?



         public GemTreasure(string treasureName, double percent, GemType gemType)
        {
            this.TreasureName = treasureName;
            this.Percent = percent;
            this.GemType = gemType;
        }
       
        
    }
}
