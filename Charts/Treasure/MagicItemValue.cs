using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class MagicItemValue
    {
        #region Properties

        public Dice Dice { get; set; }

        public MonsterTypes MagicItemTypes {get; set;}

        public int MinimumRollValue { get; set; }

        public int MaximumRollValue { get; set; }

        public string MagicItemSubtableName { get; set; }

        #endregion Properties
        
        public MagicItemValue (string magicItemSubtableName, int minimumRollValue, int maximumRollValue, string magicItemTypes)
        {
            MagicItemTypes = GetMagicItemTypes(magicItemTypes);
            MagicItemSubtableName = magicItemSubtableName;
            MinimumRollValue = minimumRollValue;
            MaximumRollValue = maximumRollValue;
            Dice Dice = Dice.D100;

        }
        private MonsterTypes GetMagicItemTypes(string magicItemTypes)
        {
            return (MonsterTypes)Enum.Parse(typeof(MonsterTypes), magicItemTypes);
        }

    }
}
