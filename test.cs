using System;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts.Treasure;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine
{
    class test
    {


        /// <summary>
        /// Display everything in monetary chart.
        /// </summary>
        public static void Main()
        {
            Charts.GetCharts FirstTest;



            FirstTest = new Charts.GetCharts();

            FirstTest.GetJewelryValueChart();

            foreach (var item in FirstTest.JewelryGPValueChart)
            {
                Console.WriteLine($"Here is the {item.JewelryType}");
                Console.WriteLine($"It is worth {item.MinimumGPValue} at minimum");
                Console.WriteLine($"Could be worth {item.MaximumGPValue}");
            }
            //FirstTest.GetMonetaryChart();


            //foreach (var item in FirstTest.MonetaryTreasure)
            //{
            //    Console.WriteLine($"MonsterType {item.Key}");

            //    foreach (var loot in item.Value)
            //    {
            //        Console.WriteLine($"   Treasure Name: {loot.TreasureName}");
            //        Console.WriteLine($"   Treasure Amount: {loot.TreasureAmount}");
            //        Console.WriteLine($"   Dice {loot.Dice}");
            //        Console.WriteLine($"   Percent: {loot.Percent}");
            //        Console.WriteLine($"   Max Roll Value: {loot.MaxRollValue}");
            //        Console.WriteLine($"   Number Of Dice: {loot.NumberOfDice}");
            //    }
            //}
            Console.ReadLine();
        }
    }
}
