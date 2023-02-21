using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Repair
{
    public class RecordedWorksheet
    {
        public int NumberOfWorks { get;  set; }
        public int MatCostOfWorks { get; set; }
        public int SumTimeOfWorks { get; set; }

        public RecordedWorksheet(int numberOfWorks, int matCostOfWorks, int sumTimeOfWorks)
        {
            this.NumberOfWorks = numberOfWorks;
            this.MatCostOfWorks = matCostOfWorks;
            this.SumTimeOfWorks = sumTimeOfWorks;
        }
    }
}
