using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class CensosAnalizerException:Exception
    {
        public enum ExceptionType
        {
            FileNotFound,InvalidFileType,IncorrectDelimeter,IncorrectHeder
        }

        public ExceptionType eType;

        public CensosAnalizerException(string massage,ExceptionType Type): base(massage) 
        {
            this.eType = Type;
        }
    }
}
