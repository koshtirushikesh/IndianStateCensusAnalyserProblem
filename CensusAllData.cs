using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class CensusAllData
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long dencity;

        public CensusAllData(CensusData censusData)
        {
            this.state=censusData.state;
            this.population=censusData.population;
            this.area=censusData.area;
            this.dencity=censusData.dencity;
        }
        public CensusAllData(StateData stateData)
        {
            this.serialNumber = stateData.serialNumber;
            this.stateName = stateData.stateName;
            this.tin = stateData.tin;
            this.stateCode = stateData.stateCode;
        }
    }
}
