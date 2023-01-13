using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class StateCensusAnalyser
    {
         string[] cencusData;
         public Dictionary<string, CensusAllData> dataMap;
        public Dictionary<string, CensusAllData> LodeCensusData(string csvFilePath, string dataHeaders)
        {
            dataMap = new Dictionary<string, CensusAllData>();
            CensusAdapterClass censusAdapterClass = new CensusAdapterClass();
            cencusData = censusAdapterClass.GetCensusData(csvFilePath, dataHeaders);

            foreach (string data in cencusData.Skip(1))
            {
                if (!data.Contains(","))
                {
                    throw new CensosAnalizerException("File Contanes Wrong Delimiter", CensosAnalizerException.ExceptionType.IncorrectDelimeter);
                }
                string[] coloum = data.Split(",");
                if (csvFilePath.Contains("CensusData.csv"))
                {
                    dataMap.Add(coloum[1], new CensusAllData(new StateData(coloum[0], coloum[1], coloum[2], coloum[3])));
                }
                //if (csvFilePath.Contains("CensusData.csv"))
                //{
                //    dataMap.Add(coloum[1], new CensusAllData(new CensusData(coloum[1], coloum[2], coloum[3], coloum[4])));
                //}

            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);
        }

    }  
}
