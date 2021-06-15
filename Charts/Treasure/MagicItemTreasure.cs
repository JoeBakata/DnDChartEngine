using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class MagicItemTreasure
    {
        #region Properties
        public Dice Dice { get; set; }
        public double Percent { get; set; }

        public bool AnyMagicItems { get; set; }

        public int NumberOfAnyMagicItems { get; set; }

        public Dictionary<MonsterTypes, Dictionary<int, int>> MagicItemTypes { get; set; }


        #endregion Properties

        public MagicItemTreasure(double percent, bool anyMagicItems, int numberOfMagicItems, string magicItemsCompressed) 
        {
            Dice = Dice.D100;
            Percent = percent;
            AnyMagicItems = anyMagicItems;
            NumberOfAnyMagicItems = numberOfMagicItems;
            if (magicItemsCompressed != "nil")
            {
            MagicItemTypes = DecompressedMagicItems(magicItemsCompressed);

            }
        }

        private Dictionary<MonsterTypes, Dictionary<int, int>> DecompressedMagicItems(string magicItemsCompressed)
        {
            Dictionary<MonsterTypes, Dictionary<int, int>> magicItemTypes = new Dictionary<MonsterTypes, Dictionary<int, int>>();
            var magicItemsDecompressed = magicItemsCompressed.Split(':');
            foreach (var item in magicItemsDecompressed)
            {
                var magicItemMinMax = item.Split(',');
                MonsterTypes itemTypes = GetMagicItemTypes(magicItemMinMax[0]);
                var MinMax = new Dictionary<int, int>();
                MinMax.Add(int.Parse(magicItemMinMax[1]), int.Parse(magicItemMinMax[2]));

                magicItemTypes.Add(itemTypes, MinMax);
            }
            return magicItemTypes;
        }

        private MonsterTypes GetMagicItemTypes(string magicItemTypes)
        {

            return (MonsterTypes)Enum.Parse(typeof(MonsterTypes), magicItemTypes);
        }

    }
}
