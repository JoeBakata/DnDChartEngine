using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;

namespace DungeonsAndDragons.ChartEngine.Resources
{
    public class GemValue
    {
        #region Properties
        public GemType GemType { get; set; }

        public int MinimumGPValue { get; set; }

        public int MaximumGPValue { get; set; }

        #endregion Properties

        public GemValue(string gemType, int minimumGPValue, int maximumGPValue)
        {
            GemType = GetGemType(gemType);
            MinimumGPValue = minimumGPValue;
            MaximumGPValue = maximumGPValue;
        }
        private GemType GetGemType(string gemtype)
        {
            //todo Below why do we use (GemType)? I don't understand in either spot what it is actually doing? I need to understand it and be able to explain it in coding terms as well as plain english.
            return (GemType)Enum.Parse(typeof(GemType), gemtype);
        }

    }

}
