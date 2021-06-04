﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonsAndDragons.ChartEngine.Services
{
    public class OpenFile
    {
        public List<string> GetMonetaryData(string MonetaryChartData = @"Resources\MonetaryChartData.txt")
        {
            List<string> MonetaryChartDataList = new List<string>();
            using (StreamReader sR = new StreamReader(MonetaryChartData))
            {
                while(!sR.EndOfStream)
                {
                    MonetaryChartDataList.Add(sR.ReadLine());
                }
            }
                return MonetaryChartDataList;
        }
    }
}
