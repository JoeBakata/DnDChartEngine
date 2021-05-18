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
            MonetaryTreasure.Add(MonsterType.A, PopulateMonitaryChartA());
            MonetaryTreasure.Add(MonsterType.B, PopulateMonitaryChartB());
            MonetaryTreasure.Add(MonsterType.C, PopulateMonitaryChartC());


        }

        public List<Treasure.MonitaryTreasure> PopulateMonitaryChartA()
        { 
            var TreasureRewards = new List<Treasure.MonitaryTreasure>();
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Copper", Dice.D6, Dice.DNull, 1000, .25));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Silver", Dice.D6, Dice.DNull, 1000, .30));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Electrum", Dice.D4, Dice.DNull, 1000, .20));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Gold", Dice.D6, Dice.D6, 1000, .35));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Platinum", Dice.D2, Dice.DNull, 1000, .25));

            return TreasureRewards;
        }
        //todo Populate this treasure chart B
        public List<Treasure.MonitaryTreasure> PopulateMonitaryChartB()
        {
            var TreasureRewards = new List<Treasure.MonitaryTreasure>();
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Copper", Dice.D8, Dice.DNull, 1000, .50));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Silver", Dice.D6, Dice.DNull, 1000, .25));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Electrum", Dice.D4, Dice.DNull, 1000, .25));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Gold", Dice.D3, Dice.D6, 1000, .25));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Platinum", Dice.D2, Dice.DNull, 1000, .25));//Not sure how to do this. Chart shows this as Nil meaning no chance to have

            return TreasureRewards;
        }

        //todo populate this treasure chart C
        public List<Treasure.MonitaryTreasure> PopulateMonitaryChartC()
        {
            var TreasureRewards = new List<Treasure.MonitaryTreasure>();
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Copper", Dice.D12, Dice.DNull, 1000, .50));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Silver", Dice.D4, Dice.DNull, 1000, .25));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Electrum", Dice.D4, Dice.DNull, 1000, .25));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Gold", Dice.D3, Dice.D6, 1000, .25));//Not sure how to do this. Chart shows this as Nil meaning no chance to have
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Platinum", Dice.D2, Dice.DNull, 1000, .25));//Not sure how to do this. Chart shows this as Nil meaning no chance to have
            
            return TreasureRewards;
        }


        #endregion Private Methods

    }
}
