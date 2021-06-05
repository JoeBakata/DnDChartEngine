using DungeonsAndDragons.ChartEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class JewelryTreasure
    {

        /// <summary>
        /// Name of the treasure.
        /// </summary>
        public string TreasureName { get; set; }

        /// <summary>
        /// Type of dice.
        /// </summary>
        public Dice Dice { get; set; }

        /// <summary>
        /// Value of jewelry
        /// </summary>


        public int MinimumValue { get; set; }

        public int MaximumValue { get; set; }

        public double Percent { get; set; }

        public int NumberOfDice { get; set; }

        public int MaxRollValue { get; set; }


        public JewelryTreasure (string treasureName, int minimumValue, int maximumValue, int numberOfDice, int maxRollValue)
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
