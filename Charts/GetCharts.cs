using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts
{
    public class GetCharts
    {
        #region Fields
        Services.OpenFile services = new Services.OpenFile();
        #endregion Fields

        public Dictionary<MonsterType, List<Treasure.MonetaryTreasure>> MonetaryTreasure = //todo What is this doing? It is more complicated than what I learned. I think it is making
            new Dictionary<MonsterType, List<Treasure.MonetaryTreasure>>(); //todo a new dictionary with value monstertype and key of list? Please explain.

        public List<Treasure.JewelryValue> JewelryGPValueChart = new List<Treasure.JewelryValue>();

        public GetCharts() //todo Why is nothing in the body of this? Because there are no parameters? This is just a Method?
        {
        }

        public void GetJewelryValueChart()
        {
            List<string> goldPieceValue = services.GetDataFile(@"Resources\JewelryValueData.txt");
            
            foreach (var item in goldPieceValue)
            {
                var firstJewelryValueData = item.Split(';');
                JewelryGPValueChart.Add(new Treasure.JewelryValue(firstJewelryValueData[0],
                    Int32.Parse(firstJewelryValueData[1]), 
                    Int32.Parse(firstJewelryValueData[2])));
            }
        }

        /// <summary>
        /// Assignment 1)Fill in treaure chart. 2)Write description.
        /// </summary>
        public void GetMonetaryChart()
        {
            //todo create a foreach loop through each line of the text file

            List<string> monetaryChartData = services.GetDataFile();
            foreach (var treasurepiece in monetaryChartData)
            {           
                string firstMonetaryChartData = treasurepiece;
            var firstSplit = firstMonetaryChartData.Split(':');
            var monsterType = GetMonsterType(firstSplit[0]);
            var secondSplit = firstSplit[1].Split(';');
                MonetaryTreasure.Add(monsterType, PopulateMonetaryChart(secondSplit));
            }

        }
        /// <summary>
        /// Create the list of monetary treasure.
        /// </summary>
        /// <param name="secondSplit"></param>
        /// <returns></returns>
        public List<Treasure.MonetaryTreasure> PopulateMonetaryChart(string[] secondSplit)
        {
            var TreasureRewards = new List<Treasure.MonetaryTreasure>();
            foreach (var element in secondSplit)
            {
                var thirdSplit = element.Split(',');
                TreasureRewards.Add(new Treasure.MonetaryTreasure(thirdSplit[0], Int16.Parse(thirdSplit[1]), Int16.Parse(thirdSplit[2]),
                    Int16.Parse(thirdSplit[3]), double.Parse(thirdSplit[4])));
            }
            return TreasureRewards;
        }

        #region Priviate Methods
        /// <summary>
        /// This gets the monster type of each monster.
        /// <example>A, B, P, etc.</example>
        /// </summary>
        /// <param name="monsterType"></param>
        /// <returns></returns>
        private MonsterType GetMonsterType(string monsterType)
        {

            return (MonsterType)Enum.Parse(typeof(MonsterType), monsterType);
        }
        #endregion Private Methods
        //todo How do we make MonetaryChartData.txt more human readable. I tried to do some research and I think you can put in spaces and then when it reads the file it can string.split
    }//todo removing the spaces I add? Can you help me with this?
}
