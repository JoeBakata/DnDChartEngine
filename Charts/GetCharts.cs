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
        public Dictionary<MonsterType, List<Treasure.MonetaryTreasure>> MonetaryTreasure =
            new Dictionary<MonsterType, List<Treasure.MonetaryTreasure>>();

        public GetCharts()
        {


            //string monstertype = "A";


        }


        #region Priviate Methods

        /// <summary>
        /// Assignment 1)Fill in treaure chart. 2)Write description.
        /// </summary>
        public void GetMonetaryChart()
        {
            //todo create a foreach loop through each line of the text file


            Services.OpenFile services = new Services.OpenFile();
            List<string> monetaryChartData = services.GetMonetaryData();
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

        private MonsterType GetMonsterType(string monsterType)
        {

            return (MonsterType)Enum.Parse(typeof(MonsterType), monsterType);

        }

        

        #endregion Private Methods

    }
}
