using DungeonsAndDragons.ChartEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class GemsTreasure
    {
        /// <summary>
        /// Name of the treasure.
        /// </summary>
        string TreasureName { get; set; }

        /// <summary>
        /// Percent.
        /// </summary>
        double Percent { get; set; }

        /// <summary>
        /// Type of Gem.
        /// </summary>
        GemType GemType { get; set; }



         public GemsTreasure(string treasureName, double percent, GemType gemType)
        {
            this.TreasureName = treasureName;
            this.Percent = percent;
            this.GemType = gemType;
        }
       

    }
}
