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
        {   //todo I think this still needs work. How are we making it decide yes an item but must be a sword, other weapon, or armor? 
            //todo also the following: any 3 except weapons, add a potion and a scroll, 2-8 potions(same as 2d4 potions), 1-4 scrolls (same as 1d4 scrolls)? I am not sure.
            //todo I guess we have to add something for dice?
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
