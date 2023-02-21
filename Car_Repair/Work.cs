using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Repair
{
    public class Work
    {
        public string WorkName { get;  private set; }
        public int WorkTime { get; private set; }
        public int WorkTimeHour { get; private set; }
        public int WorkTimeMin { get; private set; }
        public int MaterialCost { get; private set; }
        public int WorkPrice { get; private set; }

        private const int hourlyFee = 15000;

       

        public Work(string name, int time, int cost)
        {
            this.WorkName = name;
            this.WorkTime = time;
            this.MaterialCost = cost;
            this.WorkTimeHour = time / 60;
            this.WorkTimeMin = time % 60;
            this.WorkPrice = (int)((double)time / 60 * hourlyFee);
        }

        override public string ToString()
        {
            return "Workname: " + WorkName + " Worktime: " + WorkTime + " Materialcost: " + MaterialCost;
        }
    }
}
