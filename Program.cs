namespace IndianStateCensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string csvFilePath = "C:\\Users\\rushi\\source\\repos\\IndianStateCensusAnalyser\\CensusData.csv";
            string dataHeaders = "serialNumber,stateName,tin,stateCode";
            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            stateCensusAnalyser.LodeCensusData(csvFilePath,dataHeaders);
        }
    }

}