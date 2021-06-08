using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class GemValue
    {
        #region Properties
        public GemType GemType { get; set; }

        public int MinimumGPValue { get; set; }

        public int MinimumRollValue { get; set; }

        public int MaximumRollValue { get; set; }

        public Dice Dice { get; set; }
        #endregion Properties

        public GemValue(string gemType, int minimumGPValue, int minimumRollValue, int maximumRollValue)
        {
            GemType = GetGemType(gemType);
            MinimumGPValue = minimumGPValue;
            MinimumRollValue = minimumRollValue;
            MaximumRollValue = maximumRollValue;
            Dice = Dice.D100;
        }
        private GemType GetGemType(string gemType)
        {
            return (GemType)Enum.Parse(typeof(GemType), gemType);
        }

    }

}
