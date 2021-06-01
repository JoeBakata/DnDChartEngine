using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class MonitaryTreasure
    {
        #region Properties

        /// <summary>
        /// Name of the treasure.
        /// </summary>
        public string TreasureName { get; set; }

        /// <summary>
        /// Type of dice
        /// </summary>
       public Utilities.Dice Dice1 { get; set; }



        /// <summary>
        /// The amount of tresure.
        /// </summary>
        public int TreasureAmount { get; set; }

        /// <summary>
        /// Percent.
        /// </summary>
        ///<remarks>D100 Roll</remarks>
       public double Percent { get; set; }

               
        //todo use /// to create a description of two following properties, NumberOfDice & MaxRollValue
        public int NumberOfDice { get; set; }


        public int MaxRollValue { get; set; }
        
        
        
        #endregion Properties
        //todo fill in property definitions for lines 50 - 54
/// <summary>
/// instantiate new MonitaryTreasure
/// </summary>
/// <param name="treasureName">Name of the treasure type aka Copper,Silver, etc (also on line 14)</param>
/// <param name="treasureAmount"></param>
/// <param name="numberOfDice"></param>
/// <param name="maxRollValue"></param>
/// <param name="percent"></param>
        public MonitaryTreasure(string treasureName, int treasureAmount, int numberOfDice, int maxRollValue, double percent)
        {
            TreasureName = treasureName;
            Dice1 = GetDice(maxRollValue, numberOfDice);
            TreasureAmount = treasureAmount;
            NumberOfDice = numberOfDice;
            MaxRollValue = maxRollValue;
            Percent = percent;
        }

        public Utilities.Dice GetDice(int maxRollValue, int numberOfDice)
        {
            int diceValue = maxRollValue / numberOfDice;
            return (Utilities.Dice)diceValue;
        }
        //todo input the monetarychartdata in this format Monstertype:copper,amount,numberofdice,maxrollvalue,percent. 
    }

}
