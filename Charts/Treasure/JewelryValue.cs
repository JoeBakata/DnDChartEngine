using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class JewelryValue
    {
        #region Properties
        public JewelryType JewelryType { get; set; }

        public int MinimumGPValue { get; set; }

        public int MaximumGPValue { get; set; }

        #endregion Properties

        public JewelryValue(string jewelryType, int minimumGPValue, int maximumGPValue)
        {
            JewelryType = GetJewelryType(jewelryType);
            MinimumGPValue = minimumGPValue;
            MaximumGPValue = maximumGPValue;

        }
        private JewelryType GetJewelryType(string jewelryType)
        {

            return (JewelryType)Enum.Parse(typeof(JewelryType), jewelryType);

        }

    }


}

