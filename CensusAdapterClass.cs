using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class CensusAdapterClass
    {
        public string[] GetCensusData(string csvFilePath, string Dataheders)
        {
            string[] censusData;
            if(!File.Exists(csvFilePath)) 
            {
                throw new CensosAnalizerException("File Not found ", CensosAnalizerException.ExceptionType.FileNotFound);
            }if(Path.GetExtension(csvFilePath)!=".csv")
            {
                throw new CensosAnalizerException("Invalide File type", CensosAnalizerException.ExceptionType.InvalidFileType);
            }
            censusData=File.ReadAllLines(csvFilePath);
            if (censusData[0] != Dataheders)
            {
                throw new CensosAnalizerException("Incorrect heder type", CensosAnalizerException.ExceptionType.IncorrectDelimeter);
            }
            return censusData;
        }
    }
}
