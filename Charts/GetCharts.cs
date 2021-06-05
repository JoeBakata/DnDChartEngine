using DungeonsAndDragons.ChartEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine.Charts
{
    public class GetCharts
    {
        #region Fields
        Services.OpenFile services = new Services.OpenFile();
        #endregion Fields

        public Dictionary<MonsterType, List<Treasure.MonetaryTreasure>> MonetaryTreasure =
            new Dictionary<MonsterType, List<Treasure.MonetaryTreasure>>();

        public List<Treasure.JewelryValue> JewelryGPValueChart = new List<Treasure.JewelryValue>();

        public GetCharts()
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
                MonetaryTreasure.Add(monsterType, PopulateMonitaryChart(secondSplit));

            }



        }
        //todo put in a description of this Method 

        public List<Treasure.MonetaryTreasure> PopulateMonitaryChart(string[] secondSplit)
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
        


        //todo put in a description of this Method 
        #region Priviate Methods
        private MonsterType GetMonsterType(string monsterType)
        {

            return (MonsterType)Enum.Parse(typeof(MonsterType), monsterType);

        }

        

        #endregion Private Methods

    }
}
