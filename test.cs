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
        /// Display everything in monetary chart
        /// </summary>
        public static void Main()
        {
            Charts.GetCharts FirstTest;

           

            FirstTest = new Charts.GetCharts();

            //Arrange
            FirstTest.GetMonetaryChart();
            //Act

            //Assert
            // string name = FirstTest.MonetaryTreasure.First(x => x.Key == Utilities.MonsterType.A).Value.Select(x => x.)

            //todo 1 CW the following output: What dice is used for A silver, C platinum. Use a for loop because its specific. Silver and Platinum should be displayed.
            //Not sure how to do this. Once I learn to do this I am positive I can figure out how to do the rest.
            //todo 2 How to display C as well as B and A.
            //todo 4 CW the Percentage of B for electrum.
            List<MonitaryTreasure> Loot = FirstTest.MonetaryTreasure.First(x => x.Key == MonsterType.A).Value;

            //for (int i = 0; i < Loot.Count; i++)
            //{
            //    if  //Not sure what the conditional should be. I think it should be an if statement
            //     { 
            //        Console.WriteLine($"The Die used for Chart A silver is {Dice.D6}");
            //     }

            //}


            //foreach (var item in Loot)
            //{

            //    Console.WriteLine($"The items in A are {item.TreasureName}");

            //}

            Console.ReadLine();
        }
    }
}
