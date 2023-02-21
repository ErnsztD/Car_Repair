using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_Repair
{
    public class Loader<T> where T: class
    {
        private StrParser<T> strParser;

        public Loader(StrParser<T> parser)
        {
            strParser = parser;
        }

        public List<T> ParseFile(string fileName)
        {
            List<T> items = new List<T>();

            StreamReader reader = new StreamReader(fileName);

          

            while (!reader.EndOfStream)
            {
                string[] colums = reader.ReadLine().Split(';');
                items.Add(strParser.ParseStr(colums));
            }
            reader.Close();

            return items;
        }
    }
}
