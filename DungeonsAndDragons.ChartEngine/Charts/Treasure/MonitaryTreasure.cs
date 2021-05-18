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
        /// Multiple dice roll
        /// </summary>
        public Utilities.Dice Dice2 { get; set; }

        /// <summary>
        /// The amount of tresure.
        /// </summary>
        public int TreasureAmount { get; set; }

        /// <summary>
        /// Percent.
        /// </summary>
        ///<remarks>D100 Roll</remarks>
       public double Percent { get; set; }

               
        #endregion Properties

        /// <summary>
        /// Instantiate new treasure type.
        /// </summary>
        /// <param name="treasureName"></param>
        /// <param name="dice1"></param>
        /// <param name="dice2"></param>
        /// <param name="treasureAmount"></param>
        /// <param name="percent"></param>
        public MonitaryTreasure(string treasureName, Utilities.Dice dice1, Utilities.Dice dice2, int treasureAmount,
            double percent)
        {
            TreasureName = treasureName;
            Dice1 = dice1;
            Dice2 = dice2;
            TreasureAmount = treasureAmount;
            Percent = percent;
        }
    }
}
