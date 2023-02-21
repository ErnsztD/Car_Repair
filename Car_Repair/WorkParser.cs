using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Repair
{
    public class WorkParser : StrParser<Work>
    {

     

        public override Work ParseStr(string[] colums)
        {

            return new Work(colums[0], int.Parse(colums[1].Trim()), int.Parse(colums[2].Trim()));

        }
    }
}
