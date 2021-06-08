using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class GemTreasure//This is Constructor for GemTreasure?
    {//the following are the properties of the GemTreasure class?
        #region Properties 

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
        /// Number of gems found in the treasure.
        /// </summary>
        public int NumberOfGems { get; set; }
        /// <summary>
        /// Number of the dice to roll.
        /// </summary>
        public int NumberOfDice { get; set; }
        /// <summary>
        /// Highest value of gems.
        /// </summary>
        public int MaxRollValue { get; set; }
        /// <summary>
        /// Type of Gem.
        /// </summary>
        public GemType GemType { get; set; }//Is this needed? Is it wrong?

        #endregion Properties


        public GemTreasure (string treasureName, int minimumValue, int maximumValue, int numberOfDice, int maxRollValue)
        {
            TreasureName = treasureName;
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;
            NumberOfDice = numberOfDice;
            MaxRollValue = maxRollValue;
            Dice = GetDice(maxRollValue, numberOfDice);
        }
        public Dice GetDice(int maxRollValue, int numberOfDice)
        {

            if (numberOfDice == 0)
            {
                return Dice.DNull;
            }
            int diceValue = maxRollValue / numberOfDice;
            return (Dice)diceValue;
        }


    }
}
