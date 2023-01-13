using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class CensusData
    {
        public string state;
        public long population;
        public long area;
        public long dencity;

        public CensusData(string v1,string v2,string v3, string v4) 
        {
            this.state = v1;
            this.population = Convert.ToUInt32(v2);
            this.area = Convert.ToUInt32(v3);
            this.dencity = Convert.ToUInt32(v4);
        }
    }
}
