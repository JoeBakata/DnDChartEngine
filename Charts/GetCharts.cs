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
        public Dictionary<MonsterType, List<Treasure.MonitaryTreasure>> MonetaryTreasure =
            new Dictionary<MonsterType, List<Treasure.MonitaryTreasure>>();

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
            //todo finish populating the monetarychart data.txt file


            Services.OpenFile services = new Services.OpenFile();
            List<string> monetaryChartData = services.GetMonetaryData();
            string firstMonetaryChartData = monetaryChartData[0];
            var firstSplit = firstMonetaryChartData.Split(':');
            var monsterType = GetMonsterType(firstSplit[0]);
            var secondSplit = firstSplit[1].Split(';');

            MonetaryTreasure.Add(monsterType, PopulateMonitaryChart(secondSplit));
        }

        public List<Treasure.MonitaryTreasure> PopulateMonitaryChart(string[] secondSplit)
        {
            var TreasureRewards = new List<Treasure.MonitaryTreasure>();
            foreach (var element in secondSplit)
            {
                var thirdSplit = element.Split(',');
                TreasureRewards.Add(new Treasure.MonitaryTreasure(thirdSplit[0], getDice(thirdSplit[1]), getDice(thirdSplit[2]),
                    Int16.Parse(thirdSplit[3]), double.Parse(thirdSplit[4])));
            }

            return TreasureRewards;
        }


        private Dice getDice(string diceNumber)
        {
            switch(diceNumber)
            {
                case "D6":
                    return Dice.D6;
                case "D4":
                    return Dice.D4;
                case "DNull":
                    return Dice.DNull;
            }

            return Dice.DNull;
        }


        private MonsterType GetMonsterType(string monsterType)
        {
            switch(monsterType)
            {
                case "A":
                    return MonsterType.A;
                case "B":
                    return MonsterType.B;
            }

            return MonsterType.A;
        }







        #endregion Private Methods

    }
}
