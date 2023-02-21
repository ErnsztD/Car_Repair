using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Repair
{
    public abstract class StrParser<T> where T: class
    {

        public abstract T ParseStr(string[] inputStrList);
    }
}
