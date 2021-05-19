using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonsAndDragons.ChartEngine.Services
{
    public class OpenFile
    {
        public List<string> GetMonetaryData(string MonetaryChartData = @"C:\Users\Joseph\Desktop\DungeonsAndDragons.ChartEngine\DungeonsAndDragons.ChartEngine\DungeonsAndDragons.ChartEngine\Resources\MonetaryChartData.txt")
        {
            List<string> MonetaryChartDataList = new List<string>();
            using (FileStream fs = File.Open(MonetaryChartData, FileMode.Open))
            {
                MonetaryChartDataList.Add(fs.ToString());
            }





                return MonetaryChartDataList;
        }
    }
}
