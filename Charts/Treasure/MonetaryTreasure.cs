﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class MonetaryTreasure
    {
        #region Properties

        /// <summary>
        /// Name of the treasure.
        /// </summary>
        public string TreasureName { get; set; }

        /// <summary>
        /// Type of dice.
        /// </summary>
       public Utilities.Dice Dice1 { get; set; }



        /// <summary>
        /// The amount of tresure.
        /// </summary>
        public int TreasureAmount { get; set; }

        /// <summary>
        /// This is a percentange from 01-100.
        /// </summary>
        ///<remarks>D100 Roll</remarks>
        public double Percent { get; set; }

               
        /// <summary>
        /// This is the Number of Dice that gets rolled.
        /// </summary>
        public int NumberOfDice { get; set; }

        /// <summary>
        /// This is the Highest value that the rolled dice can achive.
        /// </summary>
        public int MaxRollValue { get; set; }
        
        
        
        #endregion Properties
        
        /// <summary>
        /// instantiate new MonitaryTreasure.
        /// </summary>
        /// <param name="treasureName">Name of the treasure type aka Copper,Silver, Gold, etc.</param>
        /// <param name="treasureAmount">This is the amount of the treasure. For group treasure(A-O) its in thousands. For solo (P-V) it is in pieces per monster.</param>
        /// <param name="numberOfDice">This is the number of dice that get rolled.</param>
        /// <param name="maxRollValue">This is the Highest value that the rolled dice can achive.</param>
        /// <param name="percent">This is a percentange from 01-100.</param>
        public MonetaryTreasure(string treasureName, int treasureAmount, int numberOfDice, int maxRollValue, double percent)
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
            int diceValue = maxRollValue / numberOfDice; //todo can't divide by zero even if the maxRollValue is zero. This needs to be fixed.
            return (Utilities.Dice)diceValue;
        }
    }

}
