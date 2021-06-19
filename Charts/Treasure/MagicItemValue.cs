using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    /// <summary>
    /// This is declaring the class MagicItemValue with the public access modifier.
    /// </summary>
    public class MagicItemValue
    {
        #region Properties

        /// <summary>
        /// Type of dice. Seems we are not using it as it has 0 references.
        /// </summary>
        public Dice Dice { get; set; }

        /// <summary>
        /// This is the type of magic items. Could be sword, armor, potion, ring, etc.
        /// </summary>
        public MonsterTypes MagicItemTypes {get; set;}

        /// <summary>
        /// This is the minimum value that can be rolled. This needs more description, not sure what this is
        /// </summary>
        public int MinimumRollValue { get; set; }

        /// <summary>
        /// This is the maximum value that can be rolled. But for what? This needs more description.
        /// </summary>
        public int MaximumRollValue { get; set; }

        /// <summary>
        /// This is the MagicItemSubtableName.
        /// <example> Refers to the table name for the type of item that was rolled. Sword, Potion, Ring, etc.</example>
        /// </summary>
        public string MagicItemSubtableName { get; set; }

        #endregion Properties

        //todo Should there be a region here?
        /// <summary>
        /// Instantiate MagicItemValue. Instantiate literally means "to create an instance of". In programming, this generally means to create an instance of an object. 
        /// You do that by using a constructor. A constructor is a special method of a class that initializes an object of that class.
        /// Constructors have the same name as the class they're in, and because they always return an instance of that class, a return type isn't needed.
        /// </summary>
        /// <param name="magicItemSubtableName">This refers to the Subtable Name of magic items.</param>
        /// <param name="minimumRollValue">Need to figure this out, see above summary.</param>
        /// <param name="maximumRollValue">Need to figure this out, see above summary.</param>
        /// <param name="magicItemTypes">Different types of magic items.</param>
        public MagicItemValue (string magicItemSubtableName, int minimumRollValue, int maximumRollValue, string magicItemTypes)//MagicItemValue constructor with arguements 
        {   //string magicItemSubtableName, int minimumRollValue, int maximumRollValue, string magicItemTypes.
            MagicItemTypes = GetMagicItemTypes(magicItemTypes);
            MagicItemSubtableName = magicItemSubtableName;
            MinimumRollValue = minimumRollValue;
            MaximumRollValue = maximumRollValue;
            Dice Dice = Dice.D100;

        }

        #region Private Methods 
        /// <summary>
        /// GetMagicItemTypes Method with access modifier of private and return type of MonsterTypes.
        /// </summary>
        /// <param name="magicItemTypes"></param>
        /// <returns></returns>
        private MonsterTypes GetMagicItemTypes(string magicItemTypes) //todo This is the GetMagicItemTypes Method? It has the private access modifier with return type of MonsterTypes.
        {
            return (MonsterTypes)Enum.Parse(typeof(MonsterTypes), magicItemTypes);
        }
        #endregion Private Methods
    }
}
